using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deletenewexplosions : MonoBehaviour
{
    float deleteTime = 0.8f;

    void Start()
    {

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
