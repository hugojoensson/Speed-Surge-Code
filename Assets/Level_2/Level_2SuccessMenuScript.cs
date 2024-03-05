using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_2SuccessMenuScript : MonoBehaviour
{
    public CanvasGroup MissionSuccessPanel;

    // Start is called before the first frame update
    void Start()
    {
        MissionSuccessPanel.alpha = 0;
        MissionSuccessPanel.blocksRaycasts = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            MissionSuccessPanel.alpha = 1;
            MissionSuccessPanel.blocksRaycasts = true;
        }

    }

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);

    }

    public void PlayNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
