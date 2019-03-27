using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPManagerWindEnemy : MonoBehaviour
{
    public int maxHealth = 6;
    public int currentHealth;
    public Slider healthBar;
    public GameObject deathAnimation;
    public int dropRate = 1;
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
            scoreScript.scoreValue += 3;
            FindObjectOfType<AudioManager>().Play("PlayerExplosion");
            Destroy(gameObject);

            if (Random.Range(0, 5) == dropRate)
            {
                GameObject pickupdrop = Instantiate(HPdrop, gameObject.transform.position, Quaternion.identity);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Earthbullet")
        {
            currentHealth--;
            FindObjectOfType<AudioManager>().Play("WindHitWithEarth");
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
