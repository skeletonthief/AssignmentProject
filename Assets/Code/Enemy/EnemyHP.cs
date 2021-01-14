using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHP : MonoBehaviour

{
    void start()
    {
        
    }

    void Update() 
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Lava"))
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}