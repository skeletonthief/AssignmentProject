using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnerLava : MonoBehaviour
{
    public GameObject lavaTile1,lavaTile2,lavaTile3,lavaTile4,lavaTile5,lavaTile6,lavaTile7,lavaTile8,lavaTile9,lavaTile10,lavaTile11,lavaTile12,lavaTile13,lavaTile14,lavaTile15,lavaTile16,lavaTile17,lavaTile18;
    Vector2 nextSpawnPoint;

    public void SpawnLTile1()
    {
        GameObject temp = Instantiate(lavaTile1, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    public void SpawnLTile2()
    {
        GameObject temp = Instantiate(lavaTile2, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    public void SpawnLTile3()
    {
        GameObject temp = Instantiate(lavaTile3, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    public void SpawnLTile4()
    {
        GameObject temp = Instantiate(lavaTile4, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    public void SpawnLTile5()
    {
        GameObject temp = Instantiate(lavaTile5, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    public void SpawnLTile6()
    {
        GameObject temp = Instantiate(lavaTile6, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    public void SpawnLTile7()
    {
        GameObject temp = Instantiate(lavaTile7, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    
    public void SpawnLTile8()
    {
        GameObject temp = Instantiate(lavaTile8, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    public void SpawnLTile9()
    {
        GameObject temp = Instantiate(lavaTile9, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    
    public void SpawnLTile10()
    {
        GameObject temp = Instantiate(lavaTile10, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    
    public void SpawnLTile11()
    {
        GameObject temp = Instantiate(lavaTile11, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    
    public void SpawnLTile12()
    {
        GameObject temp = Instantiate(lavaTile12, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    
    public void SpawnLTile13()
    {
        GameObject temp = Instantiate(lavaTile13, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    
    public void SpawnLTile14()
    {
        GameObject temp = Instantiate(lavaTile14, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    
    public void SpawnLTile15()
    {
        GameObject temp = Instantiate(lavaTile15, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    
    public void SpawnLTile16()
    {
        GameObject temp = Instantiate(lavaTile16, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }


    public void SpawnLTile17()
    {
        GameObject temp = Instantiate(lavaTile17, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    public void SpawnLTile18()
    {
        GameObject temp = Instantiate(lavaTile18, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    void Start()
    {
        for (int i = 0; i < 0.5; i++)
        {
            SpawnLTile1();
            SpawnLTile2();
            SpawnLTile3();
            SpawnLTile4();
            SpawnLTile5();
            SpawnLTile6();
            SpawnLTile7();
            SpawnLTile8();
            SpawnLTile9();
            SpawnLTile10();
            SpawnLTile11();
            SpawnLTile12();
            SpawnLTile13();
            SpawnLTile14();
            SpawnLTile15();
            SpawnLTile16();
            SpawnLTile17();
            SpawnLTile18();
        }
    }
}
