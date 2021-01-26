using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaAI : MonoBehaviour
{

    void Start()
    {
        GameEvents.current.onDoorwayTriggerEnter +=  OnDoorwayOpen;
    }

    private void OnDoorwayOpen()
    {   
        //0f (end location), 0f (speed)
        // speed not lower tham (30f) 
        LeanTween.moveLocalX(gameObject, -89.8f, 50f).setEaseOutQuad();
    }

    void OnTriggerEnter2D(Collider2D col)

    {
        if(col.gameObject.CompareTag("Player")) //If a player hits the collider of this obstacle
        {
                Destroy(col.gameObject);
        }
        if(col.gameObject.CompareTag("Enemy")) //If a Enemy hits the collider of this obstacle
        {
                Destroy(col.gameObject);
        }
    }

}

