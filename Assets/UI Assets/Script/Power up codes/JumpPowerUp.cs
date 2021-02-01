using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerUp : MonoBehaviour
{
    public float increase = 5f; 
    public float duration = 4f; 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("Player"))
        {
            StartCoroutine( Pickup(other) ); 
        }
    }

    IEnumerator Pickup(Collider2D player)
    {
        PlayerController playerScript = player.GetComponent<PlayerController>(); 
        if (playerScript)
            {
                GetComponent<AudioSource>().Play();
                playerScript.jumpForce += increase; 
                Debug.Log("Power up picked up!"); 
                GetComponent<SpriteRenderer>().enabled = false;
                GetComponent<Collider2D>().enabled = false;
                //Wait x amount of seconds
                yield return new WaitForSeconds(duration);
                //Reverse the effect on our player
                playerScript.jumpForce = 5f;
                Destroy(gameObject); 
            }
    }
}
