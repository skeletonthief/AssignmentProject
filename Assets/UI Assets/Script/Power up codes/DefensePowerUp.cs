using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefensePowerUp : MonoBehaviour
{
    public GameObject shield; 
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
        
        if(other.CompareTag("Enemy"))
        {
            shield.SetActive(false);
            Destroy(this.gameObject);
            
        }
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

}
