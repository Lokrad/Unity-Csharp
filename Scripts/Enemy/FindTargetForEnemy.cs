using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTargetForEnemy : MonoBehaviour
{
    public GameObject[] Allies_Objects;
    public GameObject TargetForEnemy;
    public float MinDistanceForAllies = 10000f;

    void Update()
    {   
        if (TargetForEnemy == null)
        {
             Allies_Objects = null;
             MinDistanceForAllies = 10000f;
             Allies_Objects = GameObject.FindGameObjectsWithTag("Allies");

             for(int index = 0; index <= (Allies_Objects.Length - 1); index ++)
              {
                   if (Vector3.Distance(Allies_Objects[index].transform.position, transform.position) < MinDistanceForAllies)
                   {
                       MinDistanceForAllies = Vector3.Distance(Allies_Objects[index].transform.position, transform.position);
                       TargetForEnemy = Allies_Objects[index];
                   }
             
              }
        
        }
    }
}
