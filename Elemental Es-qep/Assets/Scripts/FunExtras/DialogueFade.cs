using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class DialogueFade : MonoBehaviour
{

    void Awake()
    {

        Time.timeScale = 0f;

    }


    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            Time.timeScale = 1f;
            Destroy(gameObject);

        }

    }
}
