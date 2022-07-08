using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsOD2Wooden : MonoBehaviour
{  
   [SerializeField] int damage = 50;
   [SerializeField] float speed = 4f;

   public AttackOD2Wooden attackOD2Wooden;
   public GameObject TargetForProjectiles;

   private void Start()
   {
        attackOD2Wooden = GameObject.Find("OldTower2/WoodenTower/Spawn_projectiles").GetComponent<AttackOD2Wooden>();
   } 

   private void FixedUpdate()
   {
     TargetForProjectiles = attackOD2Wooden.Target;
     transform.position = Vector3.MoveTowards(transform.position, TargetForProjectiles.transform.position, speed*Time.fixedDeltaTime);
     if (TargetForProjectiles == null)
         {
            Destroy(this);
         }
   }


   private void OnCollisionEnter(Collision collision)
   {    
        IDamageable dmg;

        dmg = collision.gameObject.GetComponent<IDamageable>();

        if (dmg != null)
        {
            dmg.TakeDamage(damage);
        }    

        Destroy(gameObject);
   }

}
