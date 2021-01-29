﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJumpAttack : MonoBehaviour
{
    [Header("For Petrolling")] 
    [SerializeField] float moveSpeed;
    [SerializeField] Transform groundCheckPoint;
    [SerializeField] Transform wallCheckPoint;
    [SerializeField] float circleRadius;
    [SerializeField] LayerMask groundLayer;
    private float moveDirection = 1;
    private bool facingRight = true;
    private bool checkingGround;
    private bool checkingWall;

    [Header("For JumpAttack")] 
    [SerializeField] float jumpHeight;
    [SerializeField] Transform player;
    [SerializeField] Transform groundCheck;
    [SerializeField] Vector2 boxSize;
    private bool isGrounded;

    [Header("For SeeingPlayer")] 
    [SerializeField] Vector2 lineOfSite;
    [SerializeField] LayerMask playerLayer;
    private bool canSeePlayer;




    [Header("Other")] 
    private Rigidbody2D enemyRB;

    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        checkingGround = Physics2D.OverlapCircle(groundCheckPoint.position,circleRadius,groundLayer);
        checkingWall = Physics2D.OverlapCircle(wallCheckPoint.position,circleRadius,groundLayer);
        isGrounded = Physics2D.OverlapBox(groundCheck.position, boxSize, 0, groundLayer);
        canSeePlayer = Physics2D.OverlapBox(transform.position, lineOfSite, 0, playerLayer);
        if(!canSeePlayer && isGrounded)
        {
            Petrolling();
        }
    }

    void Petrolling()
    {
        if(!checkingGround || checkingWall)
        {
            if (facingRight)
            {
                Flip();
            }
            else if (!facingRight)
            {
                Flip();
            }
        }
        enemyRB.velocity = new Vector2(moveSpeed * moveDirection, enemyRB.velocity.y);
    }

    void JumpAttack()
    {
        float distanceFromPlayer = player.position.x - transform.position.x;
        
        if (isGrounded)
        {
            enemyRB.AddForce(new Vector2(distanceFromPlayer,jumpHeight), ForceMode2D.Impulse);
        }
    }

    void FlipTowardsPlayer()
    {
        float playerPosition = player.position.x - transform.position.x;
        if (playerPosition<0 && facingRight == true)
        {
            Flip();
        }
        else if (playerPosition>0 && !facingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        moveDirection *= -1;
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }

    // the blue balls of recegnishion
    private void OnDrawGizmosSelected() 
    {
        Gizmos.color = Color. blue;
        Gizmos.DrawWireSphere(groundCheckPoint.position,circleRadius);
        Gizmos.DrawWireSphere(wallCheckPoint.position,circleRadius);

        Gizmos.color = Color. red;
        Gizmos.DrawCube(groundCheck.position,boxSize);

        Gizmos.color = Color. green;
        Gizmos.DrawWireCube(transform.position,lineOfSite);
    }
}
