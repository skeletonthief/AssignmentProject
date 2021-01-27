using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTile;
    Vector2 nextSpawnPoint;

    public void SpawnTile ()
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            //spawning background 
            SpawnTile();
        }
    }
}