using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaAI : MonoBehaviour
{
    private Vector3 EposA;
    private Vector3 EposB;
    private Vector3 Npos;
    Rigidbody2D rd2d; 

    [SerializeField]
    private float FollowSpeed= 0;
    [SerializeField]
    private Transform Endposition;   
    [SerializeField]
    private Transform SpritTransform; 

    void Start()
    {
        EposA = SpritTransform.localPosition;
        EposB = Endposition.localPosition;
        Npos = EposB;
    }

    void Update()
    {
        
    }

    void StopMove()
    {
        rd2d.velocity = new Vector2(0,0);
    }

    void Move()
    {
        SpritTransform.localPosition = Vector3.MoveTowards(SpritTransform.localPosition, Npos, FollowSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)

    {
        if(col.gameObject.CompareTag("Player")) //If a player hits the collider of this obstacle
        {
                Destroy(col.gameObject);
        }
        if(col.gameObject.CompareTag("Enemy")) //If a Enemy hits the collider of this obstacle
        {
                Destroy(col.gameObject);
        }
    }
}