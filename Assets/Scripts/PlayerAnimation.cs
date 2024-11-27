using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator playerAnim;
    private Player player;
    private SpriteRenderer playerFlip;

    private void Start()
    {
        playerAnim = GetComponent<Animator>();
        player = GetComponent<Player>();
        playerFlip = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        PlayerAnimationChecker();
    }

    private void PlayerAnimationChecker()
    {
        if(player.isPlayerRunning)
        {
            playerAnim.SetBool("isRunning", true);
        }

        else if(!player.isPlayerRunning)
        {
            playerAnim.SetBool("isRunning", false);
        }
    }

    public void PlayerFlipping(float playerVelocity)
    {
        if(playerVelocity > 0)
        {
            playerFlip.flipX = false;
        }

        else if(playerVelocity < 0)
        {
            playerFlip.flipX = true;
        }
    }
}
