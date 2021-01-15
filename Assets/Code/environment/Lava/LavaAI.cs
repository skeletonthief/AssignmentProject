using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaAI : MonoBehaviour
{
    private Vector3 EposA;
    private Vector3 EposB;
    private Vector3 Npos;

    [SerializeField]
    private float MoveSpeed;
    [SerializeField]
    private Transform transformB;   
    [SerializeField]
    private Transform childTransform; 

    void Start()
    {
        EposA = childTransform.localPosition;
        EposB = transformB.localPosition;
        Npos = EposB;
    }

    
    void Update()
    {
        Move();
    }

    private void Move()
    {
        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, Npos, MoveSpeed * Time.deltaTime);
    }
}
