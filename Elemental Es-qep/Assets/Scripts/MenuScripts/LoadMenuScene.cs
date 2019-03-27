using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadMenuScene : MonoBehaviour
{
    //private float currentHealth;
    //public Animator animator;
    //private Slider healthBar;

//    void Update()
//    {
//        healthBar.value = currentHealth;

//        if (FindObjectWithTag("Player") == currentHealth <= 0)
//        {
            
//        }
//    }

//    public void OnFadeComplete()
//    {

//        animator.SetTrigger("FasdeIn");

//    }
//}

    // Update is called once per frame
    public void LoadMenu()
    {
        SceneManager.LoadScene("MenuAdded");
    }
}
