using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background5 : MonoBehaviour
{
    Material material;
    Vector2 offset;

    public float yVelocity = 0.085f;

    private void Awake()
    {
        material = GetComponent<Renderer>().material;
    }

    void Start()
    {
        offset = new Vector2(0, yVelocity);
    }

    void Update()
    {
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
