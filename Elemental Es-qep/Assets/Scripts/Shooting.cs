using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject[] bullets;

    private float shootingDelay = 0.55f;
    private float cooldownTimer = 0.6f;
    public static int currentBullet;
    

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {

            FindObjectOfType<AudioManager>().Play("SwitchWeapon");

            ++currentBullet;

            if (currentBullet + 1 > bullets.Length)
            {
                currentBullet = 0;
            }
        }
        


        cooldownTimer -= Time.deltaTime;

        if (Input.GetButton("Fire3") && cooldownTimer <= 0) 
        {
            cooldownTimer = shootingDelay;
            Debug.Log("Pew!");
            
            Instantiate(bullets[currentBullet], transform.position, transform.rotation);

            if (currentBullet == 0)
            {

                FindObjectOfType<AudioManager>().Play("FireShotTest1");

            }

            if (currentBullet == 1)
            {

                FindObjectOfType<AudioManager>().Play("RockShotTest1");

            }

            if (currentBullet == 2)
            {

                FindObjectOfType<AudioManager>().Play("WindShotTest1");

            }

            if (currentBullet == 3)
            {

                FindObjectOfType<AudioManager>().Play("WaterShotTest1");

            }
        }
    }

    //private static void PlayAudio()
    //{
    //
    //    GameObject audManager = GameObject.Find("AudioManager");
    //    AudioManager audManager = audManager.GetComponent<AudioManager>();
    //    FindObjectOfType<AudioManager>().Play("FireShotTest1");

    //}

}
