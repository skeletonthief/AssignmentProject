using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HeartSystem : MonoBehaviour
{
    //This is the player's health (player is given 3 lives)
    public GameObject[] hearts; //[0] [1] [2]
    public int life;    //3 
    private Sprite[] _livesSprites;
    [SerializeField]
    private Image _livesImg; 
    private DefensePowerUp shield;
    private bool dead; 

    
    private void Start()
    {
        life = hearts.Length;
        _livesImg.sprite = _livesSprites[life];
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
        }
    }
}
