using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private int damage = 25;
    [SerializeField] private float timeToDamage = 1f;

    private float damageTime;
    private bool isDamage = true;

    private void Start()
    {
        damageTime = timeToDamage;
    }

    private void Update()
    {
        if(!isDamage)
        {
            damageTime -= Time.deltaTime;
            if(damageTime <= 0.00001f)
            {
                isDamage = true;
                damageTime = timeToDamage;
            }
        }
    }

    private void OnCollisionStay(Collision other) 
    {
        if (other.gameObject.CompareTag("Allies"))
        {
            AlliesBase alliesBase = other.gameObject.GetComponent<AlliesBase>();

            if(alliesBase != null && isDamage == true)
            {
                alliesBase.TakeDamage(damage);
                isDamage = false;
            }
        }
    }
}
