using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartSystem : MonoBehaviour
{
    //This is the player's health (player is given 3 lives)
    public GameObject[] hearts; //[0] [1] [2]
    public int life;    //3 
    //public Transform TriggerAnimation;
    //private Animation anim; 
    private DefensePowerUp shield;
    private bool dead; 
    
    private void Start()
    {
        life = hearts.Length;
        //anim = gameObject.GetComponent<Animation>();
        //anim.Stop("CloseHeart");
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
            //animation when player takes damage                // STIL DOESNT WORK 
            //anim["CloseHeart"].wrapMode = WrapMode.Once;
            //anim.Play("CloseHeart");
            //Debug.Log("-1 heart");
            //Destroy(hearts[life].gameObject);  //[0]                                
            ////yield return new WaitForSeconds (0.5f);
            // Animation when player takes damage instead of being destroyed 
            //anim = hearts.GetComponent<Animator>();                           //I need to fix this 
            //anim.SetBool("Boost", true); 
            //then to stop animation 
            if(life < 1)
            {
                dead = true; 
                SceneManager.LoadScene("Game Over");
            }
        }
        
    }

    //checking if shield is activated 
    /*void OnTriggerEnter2D(Collider2D other) //Enemies need to be added for this to work 
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
    }*/
}
