using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{


    public CanvasGroup Optionpanel;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Levels()
    {
        Optionpanel.alpha = 1;
        Optionpanel.blocksRaycasts = true;
    }
    public void Back()
    {
        Optionpanel.alpha = 0;
        Optionpanel.blocksRaycasts = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayGameLevel_1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayGameLevel_2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void PlayGameLevel_3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }

    public void PlayGameLevel_4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }
}