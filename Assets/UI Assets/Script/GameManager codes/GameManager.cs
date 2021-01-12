using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int HighScore = 0; 
    public Text hiScoreText;
    //public ScoreManager theScoreManager; 
    // Start is called before the first frame update
    private void Start()
    {
        //theScoreManager = FindObjectOfType<ScoreManager>(); 
        HighScore = 0; 
    }
    private void Update() 
    {
        hiScoreText.text = "Best:" + PlayerPrefs.GetInt("highscore"); 
    }
    // Restart the game
    public void RestartGame()
    {
        if (HighScore > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", HighScore); 
        }
        
    }


    //private ScoreManager theScoreManager;                     //Keeps giving me errors 
    // Start is called before the first frame update
    //void Start()
    //{
    //    theScoreManager = FindObjectOfType<ScoreManager>(); 
    //}

    // Update is called once per frame
    //void Update()
    //{
    //    
    //}
    //public void RestartGame()         
    //{
    //    StartCoroutine ("RestartGameCo");
    //}
    //public IEnumerator RestartGameCo()            
    //{
    //    theScoreManager.scoreIncreasing = false; 
    //   theScoreManager.scoreCount = 0; 
    //    theScoreManager.scoreIncreasing = true; 
    //}
}
