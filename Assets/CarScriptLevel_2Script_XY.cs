using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScriptLevel_2Script_XY : MonoBehaviour
{
    public float moveSpeed = 5f; // Grundhastighet f�r spelarens r�relse
    public float accelerationRate = 2f; // Accelerationsgrad n�r piltangenterna h�lls nere

    private Rigidbody2D rb;

    private Vector2 moveDirection = Vector2.zero; // Riktning som spelaren ska r�ra sig i
    private float currentSpeed = 0f; // Aktuell hastighet

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // L�sa in input fr�n piltangenterna f�r att styra r�relsen
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Ber�kna riktning baserat p� input
        moveDirection = new Vector2(horizontalInput, verticalInput).normalized;

        // Ber�kna hastighet baserat p� hur l�nge piltangenterna h�lls nere
        currentSpeed = Mathf.MoveTowards(currentSpeed, moveSpeed, Time.deltaTime * accelerationRate);
    }

    private void FixedUpdate()
    {
        // R�r GameObjectet baserat p� ber�knad riktning och hastighet
        rb.velocity = moveDirection * currentSpeed;
    }
}
