using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarPowerUp : MonoBehaviour
{ 
    public int scoreToGive; 
    private ScoreManager theScoreManager; 

    void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>(); 
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Player" )
        {
            theScoreManager.AddScore(scoreToGive); 
            GetComponent<AudioSource>().Play();
        }
        Debug.Log("Power up picked up!"); 
        Destroy(gameObject); 
    }

}
