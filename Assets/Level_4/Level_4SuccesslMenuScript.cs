using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Skript som körs när bilen har kör in i målet och vad dom olika knaparna ska länkas till

public class Level_4SuccesslMenuScript : MonoBehaviour
{
    public CanvasGroup MissionSuccessPanel;

    void Start()
    {
        MissionSuccessPanel.alpha = 0;
        MissionSuccessPanel.blocksRaycasts = false;
    }
    // Om bilen kör in i målet så byter skärmen
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            MissionSuccessPanel.alpha = 1;
            MissionSuccessPanel.blocksRaycasts = true;
        }
    }
    // Går till Main Menu
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }
    // Stänger ner spelet
    public void QuitGame()
    {
        Application.Quit();
    }
}
