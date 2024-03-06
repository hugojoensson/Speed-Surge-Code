using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Skript för bilens rörelse för alla levels

public class CarScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    public float hastighet = 10000;

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // Rörelse åt höger
            Vector3 nuvarandePosition = transform.position;
            Vector3 nyPosition = new Vector3(nuvarandePosition.x + hastighet * Time.deltaTime, nuvarandePosition.y, nuvarandePosition.z);
            transform.position = nyPosition;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Rörelse åt vänster
            Vector3 nuvarandePosition = transform.position;
            Vector3 nyPosition = new Vector3(nuvarandePosition.x - hastighet * Time.deltaTime, nuvarandePosition.y, nuvarandePosition.z);
            transform.position = nyPosition;
        }
    }
}
