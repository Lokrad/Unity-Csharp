using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsAndProjectiles : MonoBehaviour
{  
   [SerializeField] int damage = 50;
   [SerializeField] float speed = 4f;

   public OldTower2AtacckHighRockTower atackTower;
   public GameObject TargetForProjectiles;

   private void Start()
   {
        atackTower = GameObject.Find("OldTower2/HighRockTower/Spawn_projectiles").GetComponent<OldTower2AtacckHighRockTower>();
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
