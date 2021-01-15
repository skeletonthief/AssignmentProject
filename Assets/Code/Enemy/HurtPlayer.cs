using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public int damageToGive; 
    
    // In this script enemy deals damage to player 
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            HeartSystem heartSystem = other.GetComponent<HeartSystem>();
            if(heartSystem !=null)
            {
                heartSystem.TakeDamage(damageToGive);
            }
        }
    }

}   


