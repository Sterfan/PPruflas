using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainSceneChanger : MonoBehaviour
{
    public Animator animator;

    //void Start()
    //{

    //    Scene currentScene = SceneManager.GetActiveScene();
    //    string sceneName = currentScene.name;

    //    if (sceneName == "StefansNewScene66")
    //    {

    //        animator.SetTrigger("DialogueBox1");

    //    }
    //}


    public void PlayGame()
    {

        animator.SetTrigger("FadeIn1");

    }

    void Update()
    {
        //if (sceneName("Level 1"))
        //{



        //}


        if (HealthManagerPlayer.playerAlive == false)
        {

            animator.SetTrigger("PlayerDead");

        }
    }

    //HealthManagerPlayer.playerAlive == false
}
