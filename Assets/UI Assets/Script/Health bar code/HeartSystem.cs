using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts; //[0] [1] [2]
    public int life;    //3 
    //public Animator animator; 
    private bool dead; 
    public Sprite Closedskull; 
    private void Start()
    {
        life = hearts.Length;
    }


    // Update is called once per frame
    void Update()
    {
        if (dead == true)
        {
            //Set dead code
            Debug.Log("GAME OVER");
        }
        //if (life < 1) 
        //{
        //   Destroy(hearts[0].gameObject);  
        //}else if (life < 2)
        //{
        //    Destroy(hearts[1].gameObject); 
        //}else if (life < 3)
        //{
        //    Destroy(hearts[2].gameObject); 
        //}
    }

    public void TakeDamage(int d)
    {
        //Animator anim; 
        if (life >= 1)
        {
            life -= d; //1-1=0
            Debug.Log("-1 heart"); 
            //For now just a simple sprite change
            //this.gameObject.GetComponent<SpriteRenderer>().sprite = Closedskull;
            //Destroy(hearts[life].gameObject);  //[0]
            // Animation when player takes damage instead of being destroyed 
            //anim = hearts.GetComponent<Animator>();                           //I need to fix this 
            //anim.SetBool("Boost", true); 
            if(life < 1)
            {
                dead = true; 
                SceneManager.LoadScene("Game Over");
            }
        }
        
    }
}
