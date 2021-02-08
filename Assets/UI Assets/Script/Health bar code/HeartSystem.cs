using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts; //[0] [1] [2]
    private int life; //3 lives
    //For the heart animation
    //[SerializeField]
    //private GameObject _1, _2, _3;
    //Animator _heartAnimator; 
    private bool dead;
    public AudioSource hurt; 

    private void Start()
    {
        life = hearts.Length; 
        //_heartAnimator = gameObject.GetComponent<Animator>(); 
        //if(_heartAnimator == null)
        //{
        //    Debug.Log("Animator is null");
        //}
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
                //hurt sound
                hurt.Play(); 
                //_heartAnimator.SetTrigger("OnPlayerDamage"); 
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
