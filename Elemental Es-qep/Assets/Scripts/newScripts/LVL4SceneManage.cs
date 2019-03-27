using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LVL4SceneManage : MonoBehaviour
{
    public Animator transision;
    public string sceneName;

    void Start()
    {

    }


    void Update()
    {
        if (scoreScript.scoreValue >= 150)
        {
            StartCoroutine(LoadScene());

            FindObjectOfType<AudioManager>().StopMusic("BackgroundMusic");

            FindObjectOfType<AudioManager>().Play("Boss1");

        }
    }

    IEnumerator LoadScene()
    {
        transision.SetTrigger("end");

        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }
}
