using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTargetForTowers : MonoBehaviour
{
    public GameObject[] Enemys_Objects;
    public GameObject TargetForTower;
    public float MinDistanceForEnemy = 10000f;

    void Update()
    {   
        if (TargetForTower == null)
        {
             Enemys_Objects = null;
             MinDistanceForEnemy = 10000f;
             Enemys_Objects = GameObject.FindGameObjectsWithTag("Enemys");

             for(int index = 0; index <= (Enemys_Objects.Length - 1); index ++)
              {
                   if (Vector3.Distance(Enemys_Objects[index].transform.position, transform.position) < MinDistanceForEnemy)
                   {
                       MinDistanceForEnemy = Vector3.Distance(Enemys_Objects[index].transform.position, transform.position);
                       TargetForTower = Enemys_Objects[index];
                   }
             
              }
        
        }
    }
}
