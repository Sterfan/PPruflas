using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyHUD : MonoBehaviour
{
    void Awake()
    {
        GameObject.FindGameObjectWithTag("UI");

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
