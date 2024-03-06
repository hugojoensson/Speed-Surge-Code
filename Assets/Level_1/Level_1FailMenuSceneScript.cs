using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Skript som länkas till knapparna på loss scene

public class Level_1FailMenuSceneScript : MonoBehaviour
{
    // Startar om leveln
    public void Retrylevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    // Går till Main Menu
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    // Stänger ner spelet
    public void QuitGame()
    {
        Application.Quit();
    }
}

