using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerup : MonoBehaviour
{
    public float increase = 5f; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject player = collision.gameObject; 
            Pan playerScript = player.GetComponent<Pan>(); 
            if (playerScript)
            {
                playerScript.moveSpeed += increase; 
                Debug.Log("Power up picked up!"); 
                Destroy(gameObject); 
            }
        }
    }
}
