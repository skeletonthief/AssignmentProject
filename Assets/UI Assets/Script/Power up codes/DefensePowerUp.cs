using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefensePowerUp : MonoBehaviour
{
    // For defense an animation will occur

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Animator anim; 
        if (collision.tag == "Player")
        {
            GameObject player = collision.gameObject; 
            Pan playerScript = player.GetComponent<Pan>(); 
            anim = player.GetComponent<Animator>();
            anim.SetBool("Boost", true);   
            
            if (playerScript)
            {
                Debug.Log("Power up picked up!"); 
                Destroy(gameObject); 
            }
        }
    }
}
