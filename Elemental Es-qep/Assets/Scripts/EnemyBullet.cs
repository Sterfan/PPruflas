using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private float speed = 5f;

    private Transform Player;
    private Vector2 Target;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;

        
        Target = new Vector2(Player.position.x, Player.position.y);
    }

    void Update()
    {
       
        
        transform.position = Vector2.MoveTowards(transform.position, Target, speed * Time.deltaTime);
        
    }
}
