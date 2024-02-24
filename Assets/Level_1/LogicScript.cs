using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerNearMiss;
    public Text inGameScoreText;


    [ContextMenu("Öka Near misses")]
    public void  addNearMiss()
    {
        playerNearMiss = playerNearMiss + 1;
        inGameScoreText.text = playerNearMiss.ToString();
    }
}
