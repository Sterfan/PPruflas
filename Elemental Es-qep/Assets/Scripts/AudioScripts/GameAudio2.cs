using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameAudio2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {

    }

    private void Update()
    {

        if (HealthManagerPlayer.playerAlive == false)
        {

            FindObjectOfType<AudioManager>().StopMusic("BackgroundAmbiance");

            FindObjectOfType<AudioManager>().StopMusic("BackgroundMusic");

        }

        if (Input.GetKeyDown(KeyCode.Y))
        {

            SceneManager.LoadScene("MenuAdded");

            FindObjectOfType<AudioManager>().StopMusic("BackgroundAmbiance");

            FindObjectOfType<AudioManager>().StopMusic("BackgroundMusic");

        }

        if (Input.GetKeyDown(KeyCode.P))
        {

            SceneManager.LoadScene("Boss");

            FindObjectOfType<AudioManager>().StopMusic("BackgroundAmbiance");

            FindObjectOfType<AudioManager>().StopMusic("BackgroundMusic");

        }
    }
}