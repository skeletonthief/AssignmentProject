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
            Character2DController playerScript = player.GetComponent<Character2DController>(); 
            if (playerScript)
            {
                playerScript.MovementSpeed += increase; 
                Debug.Log("Power up picked up!"); 
                Destroy(gameObject); 
            }
        }
    }
}
