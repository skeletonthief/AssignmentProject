using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] spawnObjects; 
    //public Transform[] spawnLocations;                //This is turned off since there is only one power up
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(spawnObjects[Random.Range(0, spawnObjects.Length)], this.transform); 
        //spawnLocations[Random.Range(0, spawnObjects.Length)]);        //This also had to be turned off for now 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
