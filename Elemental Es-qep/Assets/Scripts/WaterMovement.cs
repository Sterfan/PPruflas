using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMovement : MonoBehaviour
{
    private float moveSpeed = 2f;
    private float waitTime = 2f;
    private float startWaitTime = 0f;

    public Transform[] moveSpots;
    private int randomizedSpot;


    void Start()
    {
        waitTime = startWaitTime;
        randomizedSpot = Random.Range(0, moveSpots.Length);

    }

    

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomizedSpot].position, moveSpeed * Time.deltaTime);
        if (Vector2.Distance (transform.position, moveSpots[randomizedSpot].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                randomizedSpot = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}
