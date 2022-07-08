using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
   {
         void TakeDamage(int damage);
   } 

public class EnemyBase : MonoBehaviour, IDamageable
{   
   [SerializeField] int HitPoints = 100; 
   public void TakeDamage(int damage)
   {
        HitPoints -= damage;
        if (HitPoints <= 0)
        {
            Destroy(gameObject);
        }
   }


}
