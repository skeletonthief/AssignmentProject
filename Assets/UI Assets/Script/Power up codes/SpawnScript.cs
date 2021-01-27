using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] spawnObjects; 
    public Transform[] spawnLocations;                
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnLocations.Length; i++)
        {
            
            //Vector3 posToSpawn = new Vector3(Random.Range(-48f,48f),-16f,0);
            Instantiate(spawnObjects[Random.Range(0, spawnObjects.Length)], spawnLocations[i]);    
        }
        //Instantiate(spawnObjects[Random.Range(0, spawnObjects.Length)], spawnLocations[Random.Range(0, spawnObjects.Length)]);    
    }
}
