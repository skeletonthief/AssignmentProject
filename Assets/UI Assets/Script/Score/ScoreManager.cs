﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text hiScoreText;

    public float scoreCount; 
    public float hiScoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing;

    void Start()
    {
        if(PlayerPrefs.GetFloat("HighScore") != null)
        {
            hiScoreCount = PlayerPrefs.GetFloat("HighScore"); 
        }
    }


    void Update()

    {
        if(scoreIncreasing)
        {
            scoreCount += pointsPerSecond = Time.deltaTime;
        }

        if(scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hiScoreCount);
        }


        scoreText.text = "Score: " + Mathf.Round (scoreCount); 
        hiScoreText.text = "HighScore: " + Mathf.Round (hiScoreCount);
    }   
}
