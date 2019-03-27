using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEArmsHPManager : MonoBehaviour
{
    public int maxHealth = 15;
    public int currentHealth;

    public GameObject deathAnimation;
    public int dropRate = 0;
    public GameObject HPdrop;
    

    void Start()
    {
        currentHealth = maxHealth;
    }


    void Update()
    {
        

        if (currentHealth <= 0)
        {
            Instantiate(deathAnimation, transform.position, transform.rotation);
            Destroy(gameObject);
            FindObjectOfType<AudioManager>().Play("PlayerExplosion");

            if (Random.Range(0, 3) == dropRate)
            {
                GameObject pickupdrop = Instantiate(HPdrop, gameObject.transform.position, Quaternion.identity);
            }

        }

        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Firebullet")
        {
            currentHealth--;
            FindObjectOfType<AudioManager>().Play("EarthHitWithFire");
        }
        else
        {
            //currentHealth--;
            FindObjectOfType<AudioManager>().Play("WrongHit");
        }


    }
    public void TakingDamage(int damagetaken)
    {
        currentHealth -= damagetaken;
    }
}
