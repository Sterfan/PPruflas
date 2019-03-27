using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    int health = 8;
    
    private void OnTriggerEnter2D()
    {
        Debug.Log("Player Health -1");
        
        health--;
    }
    void Update()
    {
        if (health <= 0)
        {
            Debug.Log("Player is Dead");
            Die();

            
        }
    }
    void Die()
    {
       
        Destroy(gameObject);
        Application.LoadLevel(Application.loadedLevel);
    }
}
