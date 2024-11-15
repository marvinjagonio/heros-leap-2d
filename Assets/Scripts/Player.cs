using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] int movementSpeed;
    [SerializeField] float jumpForce;

    private Rigidbody2D playerRb;

    private void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void OnMovement(InputValue inputvalue)
    {
        playerRb.velocity = inputvalue.Get<Vector2>() * movementSpeed;
    }

    private void OnJump()
    {
        playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
