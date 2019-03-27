using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    int health = 8;

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
