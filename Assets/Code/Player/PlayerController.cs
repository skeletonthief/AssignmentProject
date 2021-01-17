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
    public Transform  feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    private float jumpTimeclock;
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
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if(moveInput < 0){
            transform.eulerAngles = new Vector3(0,0,0);
        }
        else if(moveInput > 0){
            transform.eulerAngles = new Vector3(0,180,0);
        }
        
        
        if(isGrounded == true && Input.GetKeyDown(KeyCode.Space)){
            isJumping = true;
            jumpTimeclock = jumpTime;
            RB.velocity = Vector2.up * jumpForce;
        }
        if(Input.GetKey(KeyCode.Space) && isJumping == true){

            if(jumpTimeclock > 0){
                RB.velocity = Vector2.up * jumpForce;
                jumpTimeclock -= Time.deltaTime;
            }    else{
                isJumping = false;
            }
            
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }
    
    }
}