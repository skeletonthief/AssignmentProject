using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAgro : MonoBehaviour
{
    [SerializeField] 
    Transform player;
    [SerializeField] 
    float agroRange = 0;
    [SerializeField] 
    float moveSpeed = 0;

    Rigidbody2D rd2d;

    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);
        
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
        if(transform.position.x < player.position.x)
        {
            //enemy left side move right
            rd2d.velocity = new Vector2(moveSpeed,0);
            transform.localScale = new Vector2 (-1,1);
        }
        else 
        {
            //enemy right side move left
            rd2d.velocity = new Vector2(-moveSpeed,0);
            transform.localScale = new Vector2 (1,1);
        }
    }
    void StopChasingPlayer()
    {
        rd2d.velocity = new Vector2(0,0);
    }
}

