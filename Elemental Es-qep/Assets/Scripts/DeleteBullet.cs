using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBullet : MonoBehaviour
{

    float deleteTime = 2f;
    public GameObject bulletExplosion;
    //public int offset.x; 
    //public int offset.y;

    void Start()
    {
        Vector2 offset = transform.position;
        offset.y += 20;
    }

    private void OnTriggerEnter2D()
    {
        Vector2 offset = transform.position;
        offset.x += 0.23f;
        offset.y += 0.27f;

        Instantiate(bulletExplosion, offset, transform.rotation);
        Destroy(gameObject);
    }

    void Update()
    {
        deleteTime -= Time.deltaTime;
        
        if (deleteTime <= 0)
        {
            Destroy(gameObject);
        }

    }
}
