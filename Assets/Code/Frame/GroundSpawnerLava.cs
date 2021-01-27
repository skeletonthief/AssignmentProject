using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnerLava : MonoBehaviour
{
    public GameObject groundTileL;
    Vector2 nextSpawnPoint;

    public void SpawnTile ()
    {
        GameObject temp = Instantiate(groundTileL, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            //spawning background 
            SpawnTile();
        }
    }
}
