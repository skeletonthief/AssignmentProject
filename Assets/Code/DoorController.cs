using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    
    private void Start()
    {
        GameEvents.current.onDoorwayTriggerEnter +=  OnDoorwayOpen;
    }

    
    private void OnDoorwayOpen()
    {
        LeanTween.moveLocalY(gameObject, 1.6f, 1f).setEaseOutQuad();
    }
}
