using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnerAI : MonoBehaviour
{
    public GameObject enemyAi;
    Vector2 nextSpawnPoint;

    public void Spawnai()
    {
        GameObject temp = Instantiate(enemyAi, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
        Spawnai();
        }
    }
}
