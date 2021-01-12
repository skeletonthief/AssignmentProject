using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public Text scoreTextG;
    public Text hiScoreTextG;

    public float pointsPerSecond;

    public float GameScore = 0f;
    public float HighScore; 

    public void Start()
    {

    }
void Update()

    {
        GameScore += pointsPerSecond * Time.deltaTime;
        PlayerPrefs.SetFloat("CurrentScore", GameScore);
        HighScore = GameScore;


        scoreTextG.text = "Score: " + Mathf.Round (GameScore); 
        
        if(GameScore > PlayerPrefs.GetFloat("HighScore"))
        {
            PlayerPrefs.SetFloat("HighScore", HighScore); 
        }
        hiScoreTextG.text = "HighScore: " + Mathf.Round (PlayerPrefs.GetFloat("HighScore"));
    }   
}
