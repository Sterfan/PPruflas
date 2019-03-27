using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    float moveSpeed = 8f;
     void Update()
    {
        Vector3 pos = transform.position;
        Vector3 Direction = new Vector3 (0, moveSpeed * Time.deltaTime);
        pos += transform.rotation * Direction;
        transform.position = pos;
    }
}
