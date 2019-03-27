using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameAudio1 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {

        FindObjectOfType<AudioManager>().StopMusic("BackgroundMusic");

        FindObjectOfType<AudioManager>().Play("Boss1");

    }

    private void Update()
    {

        if (HealthManagerPlayer.playerAlive == false)
        {

            FindObjectOfType<AudioManager>().StopMusic("BackgroundAmbiance");

            FindObjectOfType<AudioManager>().StopMusic("Boss1");

        }

        if (Input.GetKeyDown(KeyCode.Y))
        {

            FindObjectOfType<AudioManager>().StopMusic("BackgroundAmbiance");

            FindObjectOfType<AudioManager>().StopMusic("Boss1");

            SceneManager.LoadScene("MenuAdded");

        }

        if (Input.GetKeyDown(KeyCode.P))
        {

            FindObjectOfType<AudioManager>().StopMusic("BackgroundAmbiance");

            FindObjectOfType<AudioManager>().StopMusic("Boss1");

            SceneManager.LoadScene("Boss");

        }

    }
}
