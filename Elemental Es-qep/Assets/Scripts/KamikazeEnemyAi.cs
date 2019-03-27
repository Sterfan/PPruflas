using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamikazeEnemyAi : MonoBehaviour
{
    private float moveSpeed= 3f;
    
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
    }
 }