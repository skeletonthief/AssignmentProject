using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts; //[0] [1] [2]
    private int life; //3 lives
    private bool dead; 

    private void Start()
    {
        life = hearts.Length; 
    }
    void Update()
    {
        if(dead == true)
        {
            //Load Game Over Menu
            Debug.Log("you ded"); 
        }
    }

    public void TakeDamage(int d)
    {
        if(tag == "Player")
        {
            if (life >= 1)
            {
                life -= d;  //3-1=2
                Debug.Log("Ouch!"); 
                Destroy(hearts[life].gameObject); //[2]
                if(life <1)
                {
                    dead = true; 
                    SceneManager.LoadScene("Game Over");
                }
            }
        }
    }
}
