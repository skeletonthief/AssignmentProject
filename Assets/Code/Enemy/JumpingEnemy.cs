using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingEnemy : MonoBehaviour
{
    public bool faceingRight = false;
    public LayerMask whatIsGround;
    public bool isGrounded = false;
    public bool isFalling = false;
    public bool isJumping = false;

    public float jumpForceX = 2f;
    public float jumpForceY = 4f;
    public float lastYpos = 0;

    public enum Animations
    {
        Idel = 0,
        Jumping = 2,
        Falling = 2,
    };
    public Animations currentAnim;

    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public Animator anim;
    public float idleTime = 2f;
    public float currentIdelTime = 0;
    public bool isIdel = true;


    void Start()
    {
        lastYpos = transform.position.y;
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        //This if statment is called if we are idle 
        if(isIdel)
        {
            //add time to current time
            currentIdelTime += Time.deltaTime;
            //if 2 sec pass
            if(currentIdelTime >= idleTime)
            {
                //tell to jump
                currentIdelTime = 0;
                faceingRight = !faceingRight;
                spriteRenderer.flipX = faceingRight;
                Jump();
            }
        }

        // is on ground
        isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.5f,transform.position.y - 0.5f),
        new Vector2(transform.position.x + 0.5f,transform.position.y - 0.51f),whatIsGround);
        
        //we fall on ground
        if(isGrounded && !isJumping)
        {
            isFalling = false;
            isFalling = false;
            isIdel = true;
        }
        else if(transform.position.y > lastYpos && ! isIdel)
        {
            isJumping = true;
            isFalling = false;
        }
        else if (transform.position.y < lastYpos && ! isIdel)
        {
            isJumping = false;
            isFalling = true;
        }
        lastYpos = transform.position.y;
    }

    void Jump()
    {
        isJumping = true;
        int direction = 0;
        if(faceingRight == true)
        {
            direction = 1;
        }
        else
        {
            direction = -1;
        }
        rb.velocity = new Vector2(jumpForceX = direction, jumpForceY);
        Debug.Log("Jump");
    }


}
