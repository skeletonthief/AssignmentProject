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

    public float lastYPos = 0;

    public enum Animations
    {
        Idle = 0,
        Jumping = 1,
        Falling = 2,
    };

    public Animations currentAnim;

    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public Animator anim;
    
    public float idleTime = 2f;
    public float currentIdleTime = 0;
    public bool isIdle = true;


    void Start()
    {
        lastYPos = transform.position.y;
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
        if (isIdle)
        {
            //add time to current time
            currentIdleTime += Time.deltaTime;
            //if 2 sec pass
            if (currentIdleTime >= idleTime)
            {
                //tell to jump
                currentIdleTime = 0;
                faceingRight = !faceingRight;
                spriteRenderer.flipX = faceingRight;
                Jump();
            }
        }

        // is on ground
        isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.5f,transform.position.y - 0.5f),
            new Vector2(transform.position.x + 0.5f,transform.position.y - 0.51f), whatIsGround);
        
        //we fall on ground
        if(isGrounded && !isFalling)
        {   //set idle
            isJumping = false;
            isFalling = false;
            isIdle = true;
            ChangeAnimation(Animations.Idle);
        }
        else if (transform.position.y > lastYPos && !isGrounded && !isIdle)
        {   //set jump up
            isJumping = true;
            isFalling = false;
            ChangeAnimation(Animations.Jumping);
        }
        else if (transform.position.y < lastYPos && !isGrounded && !isIdle)
        {   //set falling
            isJumping = false;
            isFalling = true;
            ChangeAnimation(Animations.Falling);
        }

        lastYPos = transform.position.y;
    }

    void Jump()
    {
        isJumping = true;
        isIdle = false;
        int direction = 0;
        if(faceingRight == true)
        {
            direction = 1;
        }
        else
        {
            direction = -1;
        }
        rb.velocity = new Vector2(jumpForceX * direction, jumpForceY);
    }

    void ChangeAnimation(Animations newAnim)
    {
        if(currentAnim != newAnim)
        {
            currentAnim = newAnim;
            anim.SetInteger("state", (int)newAnim);
        }
    }

}
