using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    
    // Go to title menu 
    public void TitleMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
