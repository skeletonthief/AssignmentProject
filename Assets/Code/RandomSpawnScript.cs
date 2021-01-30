using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSpawnScript : MonoBehaviour
{
    
    // prefabs to instantiate 
    public GameObject prefab1, prefab2, prefab3, prefab4, prefab5, prefab6, prefab7, prefab8, prefab9, prefab10, prefab11, prefab12, prefab13, prefab14, prefab15, prefab16, prefab17, prefab18, prefab19, prefab20;
    public int whatToSpawn;
    public float spawnRate = 1.0f;
    public float nextSpawn = 1.0f;
    public bool hasSpawned = false;

    void Start() 
    {
        whatToSpawn = Random.Range(1,19);
    }
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 19);
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
                    case 6:
                        Instantiate (prefab6, transform.position, Quaternion.identity);
                        hasSpawned = true;
                        break;
                    case 7:
                        Instantiate (prefab7, transform.position, Quaternion.identity);
                        hasSpawned = true;
                        break;
                    case 8:
                        Instantiate (prefab8, transform.position, Quaternion.identity);
                        hasSpawned = true;
                        break;
                    case 9:
                        Instantiate (prefab9, transform.position, Quaternion.identity);
                        hasSpawned = true;
                        break;
                    case 10:
                        Instantiate (prefab10, transform.position, Quaternion.identity);
                        hasSpawned = true;
                        break;
                    case 11:
                        Instantiate (prefab11, transform.position, Quaternion.identity);
                        hasSpawned = true;
                        break;
                    case 12:
                        Instantiate (prefab12, transform.position, Quaternion.identity);
                        hasSpawned = true;
                        break;
                    case 13:
                        Instantiate (prefab13, transform.position, Quaternion.identity);
                        hasSpawned = true;
                        break;
                    case 14:
                        Instantiate (prefab14, transform.position, Quaternion.identity);
                        hasSpawned = true;
                        break;
                    case 15:
                        Instantiate (prefab15, transform.position, Quaternion.identity);
                        hasSpawned = true;
                        break;
                    case 16:
                        Instantiate (prefab16, transform.position, Quaternion.identity);
                        hasSpawned = true;
                        break;
                    case 17:
                        Instantiate (prefab17, transform.position, Quaternion.identity);
                        hasSpawned = true;
                        break;
                    case 18:
                        Instantiate (prefab18, transform.position, Quaternion.identity);
                        hasSpawned = true;
                        break;
                    case 19:
                        Instantiate (prefab19, transform.position, Quaternion.identity);
                        hasSpawned = true;
                        break;
                }
        }
    } 
}
