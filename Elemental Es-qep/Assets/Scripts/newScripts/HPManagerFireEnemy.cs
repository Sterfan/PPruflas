using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPManagerFireEnemy : MonoBehaviour
{
   [SerializeField]
    private int maxHealth = 10;
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

            //FindObjectOfType<AudioManager>().Play("PlayerExplosion");
            scoreScript.scoreValue += 10;
            Destroy(gameObject);

            if (Random.Range(0, 5) == dropRate)
            {
                GameObject pickupdrop = Instantiate(HPdrop, gameObject.transform.position, Quaternion.identity);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Waterbullet")
        {
            currentHealth--;
            FindObjectOfType<AudioManager>().Play("FireHitWithWater");
        }
        else 
        {
            //currentHealth --;
            FindObjectOfType<AudioManager>().Play("WrongHit");
        }
    }
    public void TakingDamage(int damagetaken)
    {
        currentHealth -= damagetaken;
    }
}
