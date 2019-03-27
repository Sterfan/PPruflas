using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    int health = 1;

    private void OnTriggerEnter2D()
    {
        Debug.Log(" DeleteBullet");

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
