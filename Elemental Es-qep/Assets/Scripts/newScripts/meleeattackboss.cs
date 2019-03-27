using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleeattackboss : MonoBehaviour
{
    private float moveSpeed = 0.06f;
    

    public Transform[] moveSpots;
    private int randomizedSpot;


    void Start()
    {
       
        randomizedSpot = Random.Range(0, moveSpots.Length);

    }



    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomizedSpot].position, moveSpeed);

        if (Vector2.Distance(transform.position, moveSpots[randomizedSpot].position) < 0.1f)
        {
            
            randomizedSpot = Random.Range(0, moveSpots.Length);
            transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomizedSpot].position, moveSpeed );
        }
    }
}
