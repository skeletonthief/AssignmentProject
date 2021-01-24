using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    //

    private void Start() // call lava script
    {
    //    lavecode = GetComponent<lavaAI>();
    }

//When the player collides with the triger 
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "player")
        {
            Debug.Log("hit");
        }
    }

}