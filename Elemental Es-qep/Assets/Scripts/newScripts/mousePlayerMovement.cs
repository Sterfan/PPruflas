using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousePlayerMovement : MonoBehaviour
{
    private float moveSpeed = 5f;


    void Update()
    {
        faceMouse();
    }


    void faceMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(mousePosition.x - transform.position.x,
                                        mousePosition.y - transform.position.y);
        transform.up = direction;



        Vector3 pos = transform.position;

        pos.y += Input.GetAxis("Vertical") * moveSpeed  * Time.deltaTime;
        pos.x += Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        transform.position = pos;



    }
}
