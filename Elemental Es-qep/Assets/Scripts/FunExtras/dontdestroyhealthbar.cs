using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroyhealthbar : MonoBehaviour
{
    void Awake()
    {
        GameObject.FindGameObjectWithTag("healthBar");

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
