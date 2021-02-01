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
        GetComponent<AudioSource>().Play();
        if (other.gameObject.tag == "Player" )
        {
            theScoreManager.AddScore(scoreToGive); 
        }
        Debug.Log("Power up picked up!"); 
        Destroy(gameObject); 
    }

}
