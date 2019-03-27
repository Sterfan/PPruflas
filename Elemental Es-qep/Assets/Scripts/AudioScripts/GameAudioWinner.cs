using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameAudioWinner : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {

        Destroy(GameObject.FindWithTag("Player"));

        Destroy(GameObject.FindWithTag("UI"));

        Destroy(GameObject.FindWithTag("Backgrounds"));

        FindObjectOfType<AudioManager>().StopMusic("BackgroundMusic");

        FindObjectOfType<AudioManager>().StopMusic("Boss1");

        FindObjectOfType<AudioManager>().Play("Winner");

    }

    //IEnumerator Wait()
    //{

    //    yield return new WaitForSeconds(6.865f);

    //    FindObjectOfType<AudioManager>().Play("TitleTheme2");

    //}

    private void Update()
    {

        FindObjectOfType<AudioManager>().StopMusic("Warning");

        if (Input.GetKeyDown(KeyCode.Y))
        {

            FindObjectOfType<AudioManager>().StopMusic("Winner");

            SceneManager.LoadScene("MenuAdded");

        }

    }
}
