using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameAudioLoser : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {

        FindObjectOfType<AudioManager>().Play("YouLost");

        Destroy(GameObject.FindWithTag("Player"));

        Destroy(GameObject.FindWithTag("UI"));

        Destroy(GameObject.FindWithTag("Backgrounds"));

    }

    //IEnumerator Wait()
    //{

    //    yield return new WaitForSeconds(6.865f);

    //    FindObjectOfType<AudioManager>().Play("TitleTheme2");

    //}

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {

            FindObjectOfType<AudioManager>().StopMusic("YouLost");

            SceneManager.LoadScene("MenuAdded");

        }

    }
}
