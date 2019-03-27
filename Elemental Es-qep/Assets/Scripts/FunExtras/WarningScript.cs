using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class WarningScript : MonoBehaviour
{
    public Animator animator;
    HealthManagerPlayer playerHealthYo;

    void Start()
    {
        animator.GetComponent<Animator>();
    }

    void Update()
    {
        
        if(playerHealthYo.currentHealth >= 5)
        {

            animator.SetTrigger("PlayerHurt");

        }

        else
        {

            animator.SetTrigger("PlayerHurt");

        }

    }
}
