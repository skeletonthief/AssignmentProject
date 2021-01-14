using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThanksMenu : MonoBehaviour
{
    public static bool ObjectIsCollided = false;
    public GameObject MenuUI;
    public void OnCollisionEnter2D(Collision collision)
    {
        MenuUI.SetActive(true);
        Time.timeScale = 0f; 
        ObjectIsCollided = true; 
    }
}
