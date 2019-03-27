using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPManagerWaterEnemy : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    public Slider healthBar;
    public GameObject deathAnimation;
    public int dropRate = 0;
    public GameObject HPdrop;

    void Start()
    {
        currentHealth = maxHealth;
    }


    void Update()
    {
        healthBar.value = currentHealth;

        if (currentHealth <= 0)
        {
            Instantiate(deathAnimation, transform.position, transform.rotation);
            
            Destroy(gameObject);
            scoreScript.scoreValue += 5;

            if (Random.Range(0, 5) == dropRate)
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
