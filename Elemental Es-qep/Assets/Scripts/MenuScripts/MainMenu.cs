using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System;

public class MainMenu : MonoBehaviour
{
    private bool buttonSelected;
    public EventSystem eventSystem;
    public GameObject selectedObject;
    public Animator animator;

    private void Start()
    {

        FindObjectOfType<AudioManager>().Play("TitleTheme");
        //yield return new WaitForSeconds(6.865f);
        //FindObjectOfType<AudioManager>().Play("TitleTheme2");
        StartCoroutine(Wait());

    }

    IEnumerator Wait()
    {

        yield return new WaitForSeconds(6.865f);

        FindObjectOfType<AudioManager>().Play("TitleTheme2");

    }

    private void Update()
    {
        //if (Input.GetAxisRaw("Vertical") != 0 && buttonSelected == false)
        //{
        //    eventSystem.SetSelectedGameObject(selectedObject);
        //    buttonSelected = true;
        //}

        //FindObjectOfType<AudioManager>().Play("TitleTheme");
    }

    //public void PlayGame()
    //{

    //    animator.SetTrigger("FadeOut");

    //}

    public void OnFadeComplete()
    {

        SceneManager.LoadScene("Level 1");

    }

    public void PlayGame()
    {
        animator.SetTrigger("FadeOut");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();

    }
}
