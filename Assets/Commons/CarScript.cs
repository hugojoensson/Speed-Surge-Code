using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Skript f�r bilens r�relse f�r alla levels

public class CarScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    public float hastighet = 10000;

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // R�relse �t h�ger
            Vector3 nuvarandePosition = transform.position;
            Vector3 nyPosition = new Vector3(nuvarandePosition.x + hastighet * Time.deltaTime, nuvarandePosition.y, nuvarandePosition.z);
            transform.position = nyPosition;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            // R�relse �t v�nster
            Vector3 nuvarandePosition = transform.position;
            Vector3 nyPosition = new Vector3(nuvarandePosition.x - hastighet * Time.deltaTime, nuvarandePosition.y, nuvarandePosition.z);
            transform.position = nyPosition;
        }
    }
}
