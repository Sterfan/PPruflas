using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float moveSpeed = 7.0f;
  
    void Start()
    {
        
    }

    void Update()
    {
       

        Vector3 pos = transform.position;

        pos.y += Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        pos.x += Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        transform.position = pos;
    }

   
}
