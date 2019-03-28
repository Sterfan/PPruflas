using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    public GameObject Bulletprefab;
    private float ShootingDelay = 2f;
    private float cooldownTimer = 2.5f;
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if (cooldownTimer <= 0)
        {
            cooldownTimer = ShootingDelay;
            

            if(HealthManagerPlayer.playerAlive == false)
            {

                return;

            }

            if (Bulletprefab.CompareTag("EarthEnemybullet") == true)
            {
                GameObject bullet = (GameObject)Instantiate(Bulletprefab, transform.position, transform.rotation);
                //bullet.layer = gameObject.layer;
                FindObjectOfType<AudioManager>().Play("EnemyEarthShot");

            }

            if (Bulletprefab.CompareTag("FireEnemybullet") == true)
            {
                GameObject bullet = (GameObject)Instantiate(Bulletprefab, transform.position, transform.rotation);
                //bullet.layer = gameObject.layer;
                FindObjectOfType<AudioManager>().Play("EnemyFireShot");

            }

            if (Bulletprefab.CompareTag("WaterEnemybullet") == true)
            {
                GameObject bullet = (GameObject)Instantiate(Bulletprefab, transform.position, transform.rotation);
                //bullet.layer = gameObject.layer;
                FindObjectOfType<AudioManager>().Play("EnemyWaterShot");

            }

            if (Bulletprefab.CompareTag("WindEnemybullet") == true)
            {
                GameObject bullet = (GameObject)Instantiate(Bulletprefab, transform.position, transform.rotation);
                //bullet.layer = gameObject.layer;
                FindObjectOfType<AudioManager>().Play("EnemyWindShot");

            }
        }
    }
}
