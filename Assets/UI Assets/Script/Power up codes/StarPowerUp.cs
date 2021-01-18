﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarPowerUp : MonoBehaviour
{ 
    public float increase = 5f; 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("Player"))
        {
            StartCoroutine( Pickup(other) ); 
        }
    }

    IEnumerator Pickup(Collider2D player)
    {
        Character2DController playerScript = player.GetComponent<Character2DController>(); 
        if (playerScript)
            {
                playerScript.JumpForce += increase; 
                Debug.Log("Power up picked up!"); 
                GetComponent<SpriteRenderer>().enabled = false;
                GetComponent<Collider2D>().enabled = false;
                //Wait x amount of seconds
                yield return new WaitForSeconds(increase);
                //Reverse the effect on our player
                playerScript.JumpForce = 5f;
                Destroy(gameObject); 
            }
    }
}
