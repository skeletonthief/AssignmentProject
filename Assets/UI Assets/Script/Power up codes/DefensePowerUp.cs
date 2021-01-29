using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefensePowerUp : MonoBehaviour
{
    public GameObject shield; 
    public float duration = 4f;
    private bool activeShield; 
    // Start is called before the first frame update
    void Start()
    {
        activeShield = false; 
        shield.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController player = other.GetComponent<PlayerController>();
        if (other.CompareTag ("Player"))
        {
            if(!activeShield)
            {
                shield.SetActive(true);
                activeShield = true; 
            }
            else
            {
                shield.SetActive(false);
                activeShield = false; 
            }
        }
        Debug.Log("Power up picked up!"); 
        Destroy(gameObject); 
        StartCoroutine( Pickup(other) );
    }
    public bool ActiveShield
    {
        get 
        {
            return activeShield; 
        }
        set
        {
            activeShield = value; 
        }
    }

    IEnumerator Pickup(Collider2D player)
    {
        Debug.Log("Power up picked up!"); 
        //Wait x amount of seconds
        yield return new WaitForSeconds(duration);
        //Reverse the effect on our player
        shield.SetActive(false);
        activeShield = false; 
        Destroy(shield); 
    }
    
}
