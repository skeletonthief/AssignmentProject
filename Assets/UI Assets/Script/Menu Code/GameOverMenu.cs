using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{

    public Text hiScoreText; 
    
    private void Start()
    {
        hiScoreText.text = "High Score: " + Mathf.Round(PlayerPrefs.GetFloat("HighScore")) ;
    }

    // Restart the game
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    
    // Go to title menu 
    public void TitleMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
