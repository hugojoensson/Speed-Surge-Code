using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScriptLevel_2Script_XY : MonoBehaviour
{
    public float moveSpeed = 5f; // Grundhastighet för spelarens rörelse
    public float accelerationRate = 2f; // Accelerationsgrad när piltangenterna hålls nere

    private Rigidbody2D rb;

    private Vector2 moveDirection = Vector2.zero; // Riktning som spelaren ska röra sig i
    private float currentSpeed = 0f; // Aktuell hastighet

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Läsa in input från piltangenterna för att styra rörelsen
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Beräkna riktning baserat på input
        moveDirection = new Vector2(horizontalInput, verticalInput).normalized;

        // Beräkna hastighet baserat på hur länge piltangenterna hålls nere
        currentSpeed = Mathf.MoveTowards(currentSpeed, moveSpeed, Time.deltaTime * accelerationRate);
    }

    private void FixedUpdate()
    {
        // Rör GameObjectet baserat på beräknad riktning och hastighet
        rb.velocity = moveDirection * currentSpeed;
    }
}
