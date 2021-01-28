
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJumpsOverObstacle : MonoBehaviour 
{

	float dirX;

    [SerializeField] 
    Transform playerTransform; 

	[SerializeField]
	float moveSpeed = 3f;

    [SerializeField] 
    float agroRange = 0;

	Rigidbody2D rb;
    public GameObject player;

	bool facingRight = false;

	Vector3 localScale;

	// Use this for initialization
	void Start () 
    {
		player = GameObject.FindWithTag("Player");
        playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
        localScale = transform.localScale;
		rb = GetComponent<Rigidbody2D> ();
		dirX = -1f;
	}
	
	// Update is called once per frame
	void Update () 
    {
		/*if (transform.position.x < -55f)
			dirX = 1f;
		else if (transform.position.x > 55f)
			dirX = -1f;*/
            float distToPlayer = Vector2.Distance(transform.position, playerTransform.position);

        if(distToPlayer < agroRange)
        {
            //chase player
            ChasePlayer();
        }
        else
        {
            //stop chase
            StopChasingPlayer();
        }
	}

    void ChasePlayer()
    {
        if(transform.position.x < playerTransform.position.x)
        {
            //enemy left side move right
            CheckWhereToFace();
            rb.velocity = new Vector2(moveSpeed,0);
            transform.localScale = new Vector2 (1,1);
        }
        else 
        {
            //enemy right side move left
            CheckWhereToFace();
            rb.velocity = new Vector2(-moveSpeed,0);
            transform.localScale = new Vector2 (-1,1);
        }
    }

    void StopChasingPlayer()
    {
        rb.velocity = new Vector2(0,0);
    }
	void FixedUpdate()
	{
		//rb.velocity = new Vector2 (dirX * moveSpeed, rb.velocity.y);
	}

	void LateUpdate()
	{
		CheckWhereToFace ();
	}

	void CheckWhereToFace()
	{
		if (dirX > 0)
			facingRight = true;
		else if (dirX < 0)
			facingRight = false;

		if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
			localScale.x *= -1;

		transform.localScale = localScale;
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		switch (col.tag) 
        {

		case "BigStump":
			rb.AddForce (Vector2.up * 600f);
			break;

		case "SmallStump":
			rb.AddForce (Vector2.up * 450f);
			break;
		}	
	}

}
