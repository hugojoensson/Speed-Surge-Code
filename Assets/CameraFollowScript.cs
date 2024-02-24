using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public Transform target; // Referens till det GameObject som kameran ska följa
    public float smoothSpeed = 0.125f; // Hur mjukt kameran ska följa efter GameObjectet
    public Vector3 offset; // Avståndet mellan kameran och GameObjectet

    private void FixedUpdate()
    {
        if (target == null)
            return;

        // Beräkna målpunkten där kameran ska vara
        Vector3 desiredPosition = target.position + offset;
        // Gör en mjuk övergång till målpunkten med Lerp
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        // Uppdatera kamerans position
        transform.position = smoothedPosition;
    }
}
