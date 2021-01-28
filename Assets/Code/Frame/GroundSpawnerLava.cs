using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnerLava : MonoBehaviour
{
    public GameObject lavaTile1;
    public GameObject lavaTile2;
    Vector2 nextSpawnPoint;

    public void SpawnLTile1()
    {
        GameObject temp = Instantiate(lavaTile1, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(2).transform.position;
    }

    public void SpawnLTile2()
    {
        GameObject temp = Instantiate(lavaTile2, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(2).transform.position;
    }

    void Start()
    {
        for (int i = 0; i < 1; i++)
        {
            //spawning background 
            SpawnLTile1();
            SpawnLTile2();
        }
    }
}
