using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Skript som kontrollerar knapparna i main menu
public class NewBehaviourScript : MonoBehaviour
{
    public CanvasGroup Optionpanel;
    // Startar level 1
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Byter sk�rm till d�r man kan �ndra level
    public void Levels()
    {
        Optionpanel.alpha = 1;
        Optionpanel.blocksRaycasts = true;
    }
    // G�r tillbaka till startsidan
    public void Back()
    {
        Optionpanel.alpha = 0;
        Optionpanel.blocksRaycasts = false;
    }
    // St�nger ner spelet
    public void QuitGame()
    {
        Application.Quit();
    }
    // Startar level 1
    public void PlayGameLevel_1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Startar level 2
    public void PlayGameLevel_2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    // Startar level 3
    public void PlayGameLevel_3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
    // Startar level 4
    public void PlayGameLevel_4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }
}