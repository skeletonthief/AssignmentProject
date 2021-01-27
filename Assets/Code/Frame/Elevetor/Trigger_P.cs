using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_P : MonoBehaviour
{
    private Vector3 EposA;
    private Vector3 EposB;
    private Vector3 Npos;
    public GameObject player;

    Rigidbody2D rd2d; 
    [SerializeField]
    private Transform transformB;
    [SerializeField]
    private Transform childTransform;
    
    [SerializeField] 
    Transform playerTransform; 
    [SerializeField] 
    float Proximity = 0;  
    [SerializeField] 
    private float PlatformSpeed= 0;
    



    void Start()
    {
        //Set the tag of this GameObject to player
        player = GameObject.FindWithTag("Player");
        playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
        rd2d = GetComponent<Rigidbody2D>();
        EposA = childTransform.localPosition;
        EposB = transformB.localPosition;
        Npos = EposB;
    }

    void Update()
    {
        //playerTransform = new Vector2(player.transform.position.x,player.transform.position.y);
        float distToplayer = Vector2.Distance(transform.position, playerTransform.position);
        
        if(distToplayer < Proximity)
        {
            //Stert elevetior
            Move();
        }
        else
        {
            //stop elevetior
            StopMove();
        }
    }
    void StopMove()
    {
        rd2d.velocity = new Vector2(0,0);
    }
    void Move()
    {
        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, Npos, PlatformSpeed * Time.deltaTime);
    }
}
