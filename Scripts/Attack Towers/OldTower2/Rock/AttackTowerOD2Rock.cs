using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTowerOD2Rock : FindTargetForTowers
{
   [SerializeField] public GameObject Arrows_Projectiles;
   [SerializeField] public float ShootCD = 0.5f;
   [SerializeField] public float timer = 0;

   public float DistanceForTarget;
   public float MinDistanceForAttack = 100f;
   public GameObject Target;
   public FindTargetForTowers FindTarget;

   void Start()
   {    
        FindTarget = GameObject.Find("OldTower2/RockTower").GetComponent<FindTargetForTowers>();
        if (Arrows_Projectiles == null)
            this.enabled = false;

   }

   void FixedUpdate()
   {
        
   }

   void Update()
   {    
        
        if(Target == null)
         {   
             Target = FindTarget.TargetForTower;
         } 
         if(Target != null)
             {  
                  DistanceForTarget = Vector3.Distance(Target.transform.position, transform.position);
                  if(DistanceForTarget <= MinDistanceForAttack)
                  {
                     Shoot();
                  }

              TimerTick();  
             }
   }

   void TimerTick()
   {    
        if (timer > 0.0001f)
        {
            timer -= Time.deltaTime;    
        }
        else 
            timer = 0;    
   }
   void SetTimer()
   {
        timer = ShootCD;
   }

   void Shoot()
   {
   if (timer <= 0.0001f)
    {
        Instantiate(Arrows_Projectiles, transform.position, transform.rotation);
        SetTimer();
    }
   }
}
