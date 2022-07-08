using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlliesBase : MonoBehaviour
{   
   [SerializeField] public int HitPoints = 100; 
   [SerializeField] private GameObject gameOverCanvas;
   public void TakeDamage(int damage)
   {
        HitPoints -= damage;
        if (HitPoints <= 0)
        {
            BreakOrDie();
        }
   }

   private void BreakOrDie()
   {
         Destroy(gameObject);
         gameOverCanvas.SetActive(true);
         Time.timeScale = 0f; 
   }
}
