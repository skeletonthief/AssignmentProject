using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text hiScoreText; 
    public float scoreCount; 
    public float hiScoreCount; 
    public float pointsPerSecond; 
    public int score = 0;
    string hiScoreKey = "Best";

    public bool scoreIncreasing; 

    // Start is called before the first frame update
    void Start()
    {
        //Get the highScore from player prefs if it is there, 0 otherwise.
        hiScoreCount = PlayerPrefs.GetInt(hiScoreKey,0);  
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreIncreasing)
        {
            scoreCount += pointsPerSecond = Time.deltaTime;
        }

        if(scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
        }

        scoreText.text = "Score: " + Mathf.Round (scoreCount); 
        hiScoreText.text = "Best: " + Mathf.Round (hiScoreCount);
    }
    void OnDisable()
    {
        //If our scoree is greter than highscore, set new higscore and save.
        if(scoreCount>hiScoreCount)
        {
            PlayerPrefs.SetInt(hiScoreKey, score);
            PlayerPrefs.Save();
        }
    }
}
