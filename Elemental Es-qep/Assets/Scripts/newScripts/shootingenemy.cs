using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingenemy : MonoBehaviour
{
    public GameObject Bulletprefab;
    private float ShootingDelay = 2f;
    private float cooldownTimer = 2.5f;
    
    Transform player;

    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        
        if (cooldownTimer <= 0)
        {
            cooldownTimer = ShootingDelay;
            Debug.Log("Pew!");



            if (HealthManagerPlayer.playerAlive == false)
            {

                return;

            }

            if (Bulletprefab.CompareTag("EarthEnemybullet") == true)
            {
                GameObject bullet = (GameObject)Instantiate(Bulletprefab, transform.position, transform.rotation);
                bullet.layer = gameObject.layer;

                FindObjectOfType<AudioManager>().Play("EnemyEarthShot");

            }

            if (Bulletprefab.CompareTag("FireEnemybullet") == true)
            {
                GameObject bullet = (GameObject)Instantiate(Bulletprefab, transform.position, transform.rotation);
                bullet.layer = gameObject.layer;

                FindObjectOfType<AudioManager>().Play("EnemyFireShot");

            }

            if (Bulletprefab.CompareTag("WaterEnemybullet") == true)
            {
                GameObject bullet = (GameObject)Instantiate(Bulletprefab, transform.position, transform.rotation);
                bullet.layer = gameObject.layer;

                FindObjectOfType<AudioManager>().Play("EnemyWaterShot");

            }

            if (Bulletprefab.CompareTag("WindEnemybullet") == true)
            {
                GameObject bullet = (GameObject)Instantiate(Bulletprefab, transform.position, transform.rotation);
                bullet.layer = gameObject.layer;

                FindObjectOfType<AudioManager>().Play("EnemyWindShot");

            }

            
        }
    }
}
