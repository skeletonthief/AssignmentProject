using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public int damageToGive; 
    private float hitLast = 1;
    private float hitDelay = 5;
    
    // In this script enemy deals damage to player 
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            HeartSystem heartSystem = other.GetComponent<HeartSystem>();
            if(heartSystem !=null)
            {
                Debug.Log("Ouch!"); 
                heartSystem.TakeDamage(damageToGive);
            }
            if ( Time.time < hitLast )      //When enemy deals damage there is wait peroid
            return;
            hitLast = Time.time + hitDelay;
        }
    }

    //When enemy deals damage there is wait peroid
    void OnTriggerStay (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Time.time - hitLast < hitDelay)
            return;
            Vector3 damageDirection = other.transform.position - transform.position;
            damageDirection = damageDirection.normalized;
            FindObjectOfType<HeartSystem> ().TakeDamage(damageToGive);
            hitLast = Time.time;
        }
    }
}   


