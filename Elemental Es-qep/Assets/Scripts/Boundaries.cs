using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    //private Vector2 screenboundary;
    //private float playerWidth;
    //private float playerHeight;
    float shipBoundaryRadius = 0.6f;

    void Start()
    {
        //playerWidth = transform.localScale.x / -0.19f;
        //playerHeight = transform.localScale.y / -0.19f;
        //screenboundary = new Vector2(Camera.main.aspect * Camera.main.orthographicSize + playerWidth, Camera.main.orthographicSize + playerHeight);
    }

    
    void Update()
    {
        Vector3 pos = transform.position;

        if (pos.y + shipBoundaryRadius > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
        }
        if (pos.y - shipBoundaryRadius < -Camera.main.orthographicSize)
        {
            pos.y = -Camera.main.orthographicSize + shipBoundaryRadius;
        }


        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;


        if (pos.x + shipBoundaryRadius > widthOrtho)
        {
            pos.x = widthOrtho - shipBoundaryRadius;
        }
        if (pos.x -  shipBoundaryRadius < -widthOrtho)
        {
           pos.x = -widthOrtho + shipBoundaryRadius;
        }
        transform.position = pos;
    }
}
