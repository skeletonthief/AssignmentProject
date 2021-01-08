using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public int damageToGive; 
    
    // Enemy deals damage to player 
    void OnCollisionEnter2D (Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<HeartSystem>().TakeDamage(damageToGive); 
        }
    }
    //void OnTriggerEnter2D(Collider2D other) 
    //{
    //    if(other.gameObject.tag == "Player")
    //    {
    //        other.gameObject.GetComponent<HeartSystem>().TakeDamage(damageToGive);
    //    }
    //}
}

