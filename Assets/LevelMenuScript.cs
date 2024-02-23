using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMenuScript : MonoBehaviour
{
    public CanvasGroup InGame;
    public CanvasGroup MissionSuccesPanel;
    public CanvasGroup MissionFailedPanel;

    void Start()
    {
        MissionSuccesPanel.alpha = 0;
        MissionSuccesPanel.blocksRaycasts = false;

        MissionFailedPanel.alpha = 0;
        MissionFailedPanel.blocksRaycasts = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            MissionSuccesPanel.alpha = 1;
            MissionSuccesPanel.blocksRaycasts = true;
        }

        if (collision.gameObject.layer == 6)
        {
            MissionFailedPanel.alpha = 1;
            MissionFailedPanel.blocksRaycasts = true;
        }
    }
}
