using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour
{
    //[SerializeField]
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    public EventSystem eventSystem;
    public GameObject selectedObject;

    private bool buttonSelected;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }

        //if (Input.GetAxisRaw("Vertical") != 0 && buttonSelected == false)
        //{
        //    eventSystem.SetSelectedGameObject(selectedObject);
        //    buttonSelected = true;
        //}
    }
            
           public void Resume()
            {
                pauseMenuUI.SetActive(false);
                Time.timeScale = 1f;
                GameIsPaused = false; 
            }
            

            void Pause()
            {
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0f;
                GameIsPaused = true;


            }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene("MenuAdded");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }



        }
    

