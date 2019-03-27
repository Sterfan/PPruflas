using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private float shotsDelay;
    private float shootingStart = 0.2f;

    public GameObject bullet;


    void Start()
    {
        shotsDelay = shootingStart;
    }

    
    void Update()
    {
        if (shotsDelay <= 0)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            shotsDelay = shootingStart;
        }
        else
        {
            shotsDelay -= Time.deltaTime;
        }
    }
}
