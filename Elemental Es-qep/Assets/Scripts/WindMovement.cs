using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindMovement : MonoBehaviour
{
    public float moveSpeed =3;
    public float stopDistance =3;
    public float backDistance = 2;

    private Transform Player;


    void Start()
    {
        
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    
    void Update()
    {
        if (Vector2.Distance(transform.position, Player.position) > stopDistance )
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.position, moveSpeed * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, Player.position) < stopDistance && Vector2.Distance (transform.position, Player.position)> backDistance)
        {
            transform.position = this.transform.position;
        }
        else if (Vector2.Distance (transform.position, Player.position)< backDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.position, -moveSpeed * Time.deltaTime);
        }
        //else if (GameObject.FindGameObjectWithTag("Player") == null)
        //{
        //    transform.position = Vector2.MoveTowards(transform.position, 3, 0f);
        //}
    }
}
