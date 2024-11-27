using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] int movementSpeed;
    [SerializeField] float jumpForce;
    private PlayerAnimation playerAnimation;

    private Rigidbody2D playerRb;

    public bool isPlayerRunning;

    private void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponent<PlayerAnimation>();
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
        PlayerVelocityStateCheck();

    }

    private void OnJump()
    {
        playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }


    private void PlayerVelocityStateCheck()
    {
       if(playerRb.velocity.x > 0)
       {
            isPlayerRunning = true;
            playerAnimation.PlayerFlipping(playerRb.velocity.x);

       }

       else if(playerRb.velocity.x < 0)
       {
            isPlayerRunning = true;
            playerAnimation.PlayerFlipping(playerRb.velocity.x);
        }

       else
        {
            isPlayerRunning = false;
        }
    }
}
