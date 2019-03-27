using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SecondarySceneChanger : MonoBehaviour
{

    public Animator animator;

    public void PlayGame()
    {

        animator.SetTrigger("FadeInLose");

    }

    void Update()
    {
        
    }

    //HealthManagerPlayer.playerAlive == false
}
