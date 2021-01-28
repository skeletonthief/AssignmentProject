using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAgro : MonoBehaviour
{
    [SerializeField] 
    Transform playerTransform; 
    [SerializeField] 
    float agroRange = 0;
    [SerializeField] 
    float moveSpeed = 0;
    public GameObject player;

    Rigidbody2D rd2d;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
        rd2d = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        //float distToPlayer = Vector2.Distance(transform.position, player.position);
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
            rd2d.velocity = new Vector2(moveSpeed,0);
            transform.localScale = new Vector2 (1,1);
        }
        else 
        {
            //enemy right side move left
            rd2d.velocity = new Vector2(-moveSpeed,0);
            transform.localScale = new Vector2 (-1,1);
        }
    }
    void StopChasingPlayer()
    {
        rd2d.velocity = new Vector2(0,0);
    }
}

