using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public Transform target; // Referens till det GameObject som kameran ska f�lja
    public float smoothSpeed = 0.125f; // Hur mjukt kameran ska f�lja efter GameObjectet
    public Vector3 offset; // Avst�ndet mellan kameran och GameObjectet

    private void FixedUpdate()
    {
        if (target == null)
            return;

        // Ber�kna m�lpunkten d�r kameran ska vara
        Vector3 desiredPosition = target.position + offset;
        // G�r en mjuk �verg�ng till m�lpunkten med Lerp
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        // Uppdatera kamerans position
        transform.position = smoothedPosition;
    }
}
