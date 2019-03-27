using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnemyPattern : MonoBehaviour
{
    private float moveSpeed = 3f;
    private float waitTime = 2f;
    private float startWaitTime = 0f;

    public Transform[] points;
    private int randomPoint;


    void Start()
    {
        waitTime = startWaitTime;
        randomPoint = Random.Range(0, points.Length);

    }



    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, points[randomPoint].position, moveSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, points[randomPoint].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                randomPoint = Random.Range(0, points.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}
