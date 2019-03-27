using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWshieldHPManager : MonoBehaviour
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
            scoreScript.scoreValue += 10;

            if (Random.Range(0, 3) == dropRate)
            {
                GameObject pickupdrop = Instantiate(HPdrop, gameObject.transform.position, Quaternion.identity);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Windbullet")
        {
            currentHealth--;
            FindObjectOfType<AudioManager>().Play("WaterHitWithWind");
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
