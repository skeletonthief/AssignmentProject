using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;

    private void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        groundSpawner.SpawnGTile();
        //groundSpawner.SpawnLTile();
        // 10 seconds
        Destroy(gameObject, 10);
    }

    private void Update()
    {
        
    }
}
