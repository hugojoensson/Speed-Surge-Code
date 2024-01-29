using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    public float hastighet = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
