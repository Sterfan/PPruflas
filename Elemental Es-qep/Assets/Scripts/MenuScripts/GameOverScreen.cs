using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;

public class GameOverScreen : MonoBehaviour
{

    public EventSystem eventSystem;

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void MenuLoadGameOver()
    {
        SceneManager.LoadScene("MenuAdded");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Level 1");
    }
}
