using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Skript som k�rs n�r bilen har k�r in i m�let och vad dom olika knaparna ska l�nkas till

public class Level_4SuccesslMenuScript : MonoBehaviour
{
    public CanvasGroup MissionSuccessPanel;

    void Start()
    {
        MissionSuccessPanel.alpha = 0;
        MissionSuccessPanel.blocksRaycasts = false;
    }
    // Om bilen k�r in i m�let s� byter sk�rmen
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            MissionSuccessPanel.alpha = 1;
            MissionSuccessPanel.blocksRaycasts = true;
        }
    }
    // G�r till Main Menu
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }
    // St�nger ner spelet
    public void QuitGame()
    {
        Application.Quit();
    }
}
