using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody2d;
    [SerializeField] float ballspeed = 5;
    Vector2 moveDirection;
    Vector2 currentVelocity;

    void Start()
    {
        rigidbody2d.velocity = Vector2.up * ballspeed; // La bola se moverá hacia arriba
    }

    private void FixedUpdate()
    {
        // Guardamos la velocidad de la bola
        currentVelocity = rigidbody2d.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    { 
        // En modeDirection capturamos la velocidad de la normal al colisionar 
        moveDirection = Vector2.Reflect(currentVelocity, collision.GetContact(0).normal); // 0 es el primer contacto
        // Le ponemos la velocidad a la bola
        rigidbody2d.velocity = moveDirection;
    }
}
