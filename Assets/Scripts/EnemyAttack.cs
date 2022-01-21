using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damage = 40f;


    private void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }


    public void AttackHitEvent()
    {

        if (target == null) return;
        target.TakePlayerDamage(damage);
        Debug.Log("jeb jeb");
    }
}
