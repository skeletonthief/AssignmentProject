using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_P : MonoBehaviour
{
    private Vector3 EposA;
    private Vector3 EposB;
    private Vector3 Npos;
    
    Rigidbody2D rd2d; 
    [SerializeField]private Transform transformB;
    [SerializeField]private Transform childTransform;
    
    [SerializeField] Transform player; 
    [SerializeField] float agroRange = 0;  
    [SerializeField]private float MoveSpeed= 0;

    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
        EposA = childTransform.localPosition;
        EposB = transformB.localPosition;
        Npos = EposB;
    }

    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);
        
        if(distToPlayer < agroRange)
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
        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, Npos, MoveSpeed * Time.deltaTime);
    }
}
