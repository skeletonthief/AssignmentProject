using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartSystem : MonoBehaviour
{
    //This is the player's health (player is given 3 lives)
    public GameObject[] hearts; //[0] [1] [2]
    public int life;    //3 
    private DefensePowerUp shield;
    private bool dead; 
    public GameObject closeskull; 
    private bool skullclosed; 
    
    private void Start()
    {
        life = hearts.Length;
        shield = GetComponent<DefensePowerUp>(); 
    }


    // Update is called once per frame
    void Update()
    {
        if (dead == true)
        {
            //Set dead code
            Debug.Log("GAME OVER");
        }
        
    }

    public void TakeDamage(int d)
    {
        if (life >= 1)
        {
            life -= d; //1-1=0
            if(!skullclosed)
            {
                closeskull.SetActive(true);
                skullclosed = true; 
            }
            else
            {
                closeskull.SetActive(false);
                skullclosed = false; 
            }
            if(life < 1)
            {
                dead = true; 
                SceneManager.LoadScene("Game Over");
            }
        }
        
    }

    //checking if shield is activated 
    void OnTriggerEnter2D(Collider2D other) //Enemies need to be added for this to work 
    {
        if(!shield.ActiveShield)
        {
            if(other.tag == "Enemy" )
            {
                Destroy(this.gameObject);
            }
            else if(other.tag == "Lava")
            {
                Destroy(this.gameObject);
            }
        }
    }
}
