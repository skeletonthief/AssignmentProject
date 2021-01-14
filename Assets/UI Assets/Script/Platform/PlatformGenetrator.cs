using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenetrator : MonoBehaviour
{
    [SerializeField]private Transform platformsStart; 
    [SerializeField] private Transform platforms; 
    private void Awake()
    {
        Transform lastPlatfomsTransform; 
        //Spawning the platforms by finding the end position
        lastPlatfomsTransform =SpawnPlatform(platformsStart.Find("EndPosition").position); 
        lastPlatfomsTransform =SpawnPlatform(lastPlatfomsTransform.Find("EndPosition").position);
        lastPlatfomsTransform =SpawnPlatform(lastPlatfomsTransform.Find("EndPosition").position);
        lastPlatfomsTransform =SpawnPlatform(lastPlatfomsTransform.Find("EndPosition").position);
        
    }
    
    private Transform SpawnPlatform(Vector3 spawnPosition)
    {
        Transform platformsTransform = Instantiate(platforms,spawnPosition, Quaternion.identity);
        return platformsTransform; 
    }
    
    
    
    
    //this is wrong 
    /*public GameObject thePlatform;
    public Transform generationPoint; 
    public float distanceBetween; 
    private float platformWidth; 
    // Start is called before the first frame update
    void Start()
    {
        //Spawning the platforms
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x; 
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);
            Instantiate (thePlatform, transform.position, transform.rotation); 
        }
    }
    */
}

