using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
   public GameObject[] IntEnemys;
   Text WoodensText;
   Text RocksText;
   Text GhostsText;
   Text EnemysText;
   public int Enemys;

   protected void Start()
   {
        WoodensText = GetComponent<Text>();
        RocksText = GetComponent<Text>();
        GhostsText = GetComponent<Text>();
        EnemysText = GetComponent<Text>();
   } 

   public static class Resources
   {
    /* //*  static int Woods = 50;
      static int Rocks = 20;
      static int Ghosts = 5;
      

      public static void AddWoods(int WoodsValue)
      {
            Woods += WoodsValue;
      }
      public static void AddRocks(int RocksValue)
      {
            Rocks += RocksValue;
      }
      public static void AddGhosts(int GhostsValue)
      {
            Ghosts += GhostsValue;
      }
      public static void AddEnemys(int EnemysValue)
      {
            Enemys += EnemysValue;
      } // */
   }
   public void Update()
   {
        if (IntEnemys != null && IntEnemys == null)
        {
             IntEnemys = GameObject.FindGameObjectsWithTag("Enemys");
             Enemys = IntEnemys.Length;   
        }
   }    
}
