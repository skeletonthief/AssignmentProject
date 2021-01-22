using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSpawnScript : MonoBehaviour
{
    
    // prefabs to instantiate 
    public GameObject prefab1, prefab2, prefab3, prefab4, prefab5;
    public int whatToSpawn;
    public float spawnRate = 1.0f;
    public float nextSpawn = 1.0f;
    public bool hasSpawned = false;

    void Start() 
    {
        whatToSpawn = Random.Range(1,5);
    }
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 5);
            nextSpawn = Time.time + spawnRate;
        }
        if(hasSpawned == false)
        {
            switch (whatToSpawn)
                { 
                    case 1:
                        Instantiate (prefab1, transform.position, Quaternion.identity);
                        hasSpawned = true;
                        break;
                    case 2:
                        Instantiate (prefab2, transform.position, Quaternion.identity);
                        hasSpawned = true;
                        break;
                    case 3:
                        Instantiate (prefab3, transform.position, Quaternion.identity);
                        hasSpawned = true;
                        break;
                    case 4:
                        Instantiate (prefab4, transform.position, Quaternion.identity);
                        hasSpawned = true;
                        break;
                    case 5:
                        Instantiate (prefab5, transform.position, Quaternion.identity);
                        hasSpawned = true;
                        break;
                }
        }
    } 
}
