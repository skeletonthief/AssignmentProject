using System.Collections;
using UnityEngine;
using UnityEngine.UI; 
public class Game_Manager : MonoBehaviour
{
    
    private ScoreManager theScoreManager;
    private void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
    }

    public void RestartGame()
    {
        StartCoroutine ("RestartGameCo");
    }
    public IEnumerator RestartGameCo()
    {
        theScoreManager.scoreIncreasing = false; 
        yield return new WaitForSeconds(0.5f);

        theScoreManager.scoreCount = 0; 
        theScoreManager.scoreIncreasing = true; 
    }
}

