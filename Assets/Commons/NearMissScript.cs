using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Skript f�r near misses


public class NearMissScript : MonoBehaviour
{
    public LogicScript logic;

    // Letar efter logic spelobjektet
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Om spelojektet med skriptet p� koliderar med ett annat objekt med det 3e lagret s� regestreras en near miss
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addNearMiss();
        }
    }
}
