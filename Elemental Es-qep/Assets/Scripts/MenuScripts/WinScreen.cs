using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public EventSystem eventSystem;

    public void MenuLoadGameOver()
    {
        SceneManager.LoadScene("MenuAdded");
    }
}
