using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthEnemyShooting : MonoBehaviour
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
            Debug.Log("Pew!");

            GameObject bullet = (GameObject)Instantiate(Bulletprefab, transform.position, transform.rotation);
            bullet.layer = gameObject.layer;

            FindObjectOfType<AudioManager>().Play("RockShotTest1");

        }
    }
}
