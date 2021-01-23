using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2J : MonoBehaviour
{
    [SerializeField]
    private Transform TriggerElevator;
    public float speed; 
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D RB;

    private bool facingRight = true;

    private bool isGrounded;
    public Transform  groundcheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpsValue;

    void Start()
    {
        extraJumps = extraJumpsValue;
        RB = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundcheck.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxis("Horizontal");
        Debug.Log(moveInput);
        RB.velocity = new Vector2(moveInput * speed, RB.velocity.y);

        if(facingRight == false && moveInput < 0)
        {
            flip();
        }
        else if (facingRight == true && moveInput > 0)
        {
            flip();
        }
        
    }
    void Update() //keybord hotkey

    {
        if(isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }
        if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0)
        {
            RB.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }else if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && isGrounded == true)
        {
            RB.velocity = Vector2.up * jumpForce;
        }
    }
    void flip () 
    {
        facingRight =! facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler; 
    }
}