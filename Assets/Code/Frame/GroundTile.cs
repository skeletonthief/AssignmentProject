using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;

    private void Start()
    {
        //groundSpawner = GameObject.FindObjectType<GroundSpawner>(); // error
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        groundSpawner.SpawnGTile();
        //groundSpawner.SpawnLTile();
        // 2 seconds
        Destroy(gameObject, 2);
    }

    private void Update()
    {
        
    }
}
