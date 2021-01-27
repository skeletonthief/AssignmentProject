using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaAI : MonoBehaviour
{
    public int id;

    void Start()
    {
        GameEvents.current.onDoorwayTriggerEnter +=  OnDoorwayOpen;
    }

    private void OnDoorwayOpen(int id)
    {   
        if (id == this.id)
        {
            //0f (end location), 0f (speed)
            // speed not lower tham (30f) 
            LeanTween.moveLocalX(gameObject, -89.8f, 60f).setEaseOutQuad();
        }
    }

    void OnTriggerEnter2D(Collider2D col)

    {
        if(col.gameObject.CompareTag("Player")) //If a player hits the collider of this obstacle
        {
                Destroy(col.gameObject);
                // Then loads Game Over Menu
                SceneManager.LoadScene("Game Over");
        }
        if(col.gameObject.CompareTag("Enemy")) //If a Enemy hits the collider of this obstacle
        {
                Destroy(col.gameObject);
        }
    }

}

