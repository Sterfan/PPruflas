using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManagerPlayer : MonoBehaviour
{

    public float  maxHealth = 20f;
    public float  currentHealth;
    public Slider healthBar;
    public GameObject deathAnimation;
    public float waitForIT = 0.5f;
    public float cooldown = 0.5f;
    public static bool playerAlive;

    void Start()
    {
        currentHealth = maxHealth;
        playerAlive = true;
    }


    void Update()
    {
        healthBar.value = currentHealth;

        if (currentHealth > 5)
        {

            FindObjectOfType<AudioManager>().StopMusic("Warning");

        }


        if (currentHealth <= 0)
        {
            cooldown -= Time.deltaTime;
            playerAlive = false;

            

            Instantiate(deathAnimation, transform.position, transform.rotation);

            FindObjectOfType<AudioManager>().StopMusic("Warning");

            FindObjectOfType<AudioManager>().Play("PlayerDeath");

            if (cooldown <= 0)
            {
                PlayerColorChange.spriteVersion = 0;
                Shooting.currentBullet = 0;
                scoreScript.scoreValue = 0;
                Destroy(gameObject);
                cooldown = waitForIT;
                SceneManager.LoadScene("EndScreen");
            }


        }

    }

    //public void OnFadeComplete()
    //{

    //    animator.SetTrigger("FasdeIn");

    //}

    void OnTriggerEnter2D(Collider2D other)
    {
        
       if (other.gameObject.tag == "HP" && currentHealth != maxHealth)
        {
            currentHealth = currentHealth + 5f;
        }

        else if (other.gameObject.tag != "HP")
        {
            //Camera.main.GetComponent<ScreenShake>().Shake(0.1f, 0.1f);
            currentHealth--;

            if (currentHealth <= 5)
            {

                FindObjectOfType<AudioManager>().Play("Warning");

            }

            //if (currentHealth <= 5)
            //{

            //    FindObjectOfType<AudioManager>().StopMusic("Warning");

            //}
        }


       if (other.gameObject.tag == "EarthEnemy")
        {
            Camera.main.GetComponent<ScreenShake>().Shake(0.2f, 0.2f);
            currentHealth -= 5;
        }

    }
    //public void TakingDamage(int damagetaken)
    //{
    //    currentHealth -= damagetaken;
    //}
}
