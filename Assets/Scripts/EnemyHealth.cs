using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField] float hitPoints = 100f;

    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");

        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            GetComponent<Animator>().SetTrigger("death");
            GetComponent<NavMeshAgent>().enabled = false;
            GetComponent<EnemyAI>().enabled = false;
        }
    }

}
