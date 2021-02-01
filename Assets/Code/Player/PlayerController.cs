using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D RB;
    public float speed; 
    public float jumpForce;
    private float moveInput;

    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    private float jumpTimeClock;
    public float jumpTime;
    private bool isJumping;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        RB = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate() //move
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        RB.velocity = new Vector2(moveInput * speed, RB.velocity.y);
    }

    void Update() //Grounded check and jump
    {
        if (moveInput == 0)
        {
            anim.SetBool("isRunning",false);
        }
        else 
        {
            anim.SetBool("isRunning",true);
        }
        
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        
        if(moveInput > 0)
        {
            transform.eulerAngles = new Vector3(0,180,0);
        }
        else if(moveInput < 0)
        {
            transform.eulerAngles = new Vector3(0,0,0);
        }
        
            //replace space with anything = (Space) 
        if(isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("JumpUP");
            isJumping = true;
            jumpTimeClock = jumpTime;
            RB.velocity = Vector2.up * jumpForce;
            //jump sound
            GetComponent<AudioSource>().Play();
        }
        
        if(Input.GetKey(KeyCode.Space) && isJumping == true)
        {

            if(jumpTimeClock > 0)
            {
                RB.velocity = Vector2.up * jumpForce;
                jumpTimeClock -= Time.deltaTime;
                anim.SetBool("isJUMPING", false);
            } 
            else 
            {
                isJumping = false;
                anim.SetBool("isJUMPING", true);
            }
            
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }
    }
}

