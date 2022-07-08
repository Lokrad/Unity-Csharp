using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsOD2Rock : MonoBehaviour
{  
   [SerializeField] int damage = 50;
   [SerializeField] float speed = 4f;

   public AttackTowerOD2Rock atackTower;
   public GameObject TargetForProjectiles;

   private void Start()
   {
        atackTower = GameObject.Find("OldTower2/RockTower/Spawn_projectiles").GetComponent<AttackTowerOD2Rock>();
   } 

   private void FixedUpdate()
   {
     TargetForProjectiles = atackTower.Target;
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
