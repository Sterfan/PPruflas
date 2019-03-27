using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnemyDamage : MonoBehaviour
{
    int health = 4;

    private void OnTriggerEnter2D()
    {
        Debug.Log(" Enemy is Dead");

        health--;
    }
    void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
