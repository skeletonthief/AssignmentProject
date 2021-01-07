using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int hiScore;
    string hiScoreKey = "Best";
    private ScoreManager theScoreManager; 
    // Start is called before the first frame update
    void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>(); 
        hiScore = PlayerPrefs.GetInt(hiScoreKey,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

        
    public void RestartGame()
    {
        StartCoroutine ("RestartGameCo"); 
    }
    
    
}
