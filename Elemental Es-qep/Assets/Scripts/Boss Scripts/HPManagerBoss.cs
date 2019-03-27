using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HPManagerBoss : MonoBehaviour
{
    public int maxHealth = 25;
    public int currentHealth;
    public Slider healthBar;
    public GameObject deathAnimation;
    public float waitForIT = 1;
    public float cooldown = 1;
    public static bool win;


    void Start()
    {
        currentHealth = maxHealth;
        win = false;
    }


    void Update()
    {
        healthBar.value = currentHealth;
      
        if (currentHealth <= 0)
        {
            scoreScript.scoreValue = 0;
            PlayerColorChange.spriteVersion = 0;
            Shooting.currentBullet = 0;
            win = true;
            cooldown -= Time.deltaTime;
            Instantiate(deathAnimation, transform.position, transform.rotation);
            
            FindObjectOfType<AudioManager>().Play("PlayerExplosion");
            if (cooldown <= 0)
            {
                Destroy(gameObject);
                cooldown = waitForIT;
                SceneManager.LoadScene("WinScreen");
            }


        }
    }
    private void OnTriggerEnter2D()
    {
        
        
            currentHealth -= 5;
            FindObjectOfType<AudioManager>().Play("WindHitWithEarth");
        
        
    }
    public void TakingDamage(int damagetaken)
    {
        currentHealth -= damagetaken;
    }

    
}





