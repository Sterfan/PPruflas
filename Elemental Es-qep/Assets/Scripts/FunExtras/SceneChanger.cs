using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public Animator animator;
    
    public void PlayGame()
    {

        animator.SetTrigger("FadeOut");

    }

    public void OnFadeComplete()
    {

        SceneManager.LoadScene("Level 1");

    }
}
