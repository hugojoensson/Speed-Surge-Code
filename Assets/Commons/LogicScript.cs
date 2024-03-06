using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Skript för near misses

public class LogicScript : MonoBehaviour
{
    public int playerNearMiss;
    public int playerNearMiss2;
    public Text inGameScoreText;
    public Text inGameScoreText2;

    [ContextMenu("Öka Near misses")]
    public void  addNearMiss()
    {
        playerNearMiss = playerNearMiss + 1;
        inGameScoreText.text = playerNearMiss.ToString();

        playerNearMiss2 = playerNearMiss2 + 1;
        inGameScoreText2.text = playerNearMiss2.ToString();
    }
}
