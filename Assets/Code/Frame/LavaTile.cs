using UnityEngine;

public class LavaTile : MonoBehaviour
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
        // 5 seconds
        Destroy(gameObject, 5);
    }

    private void Update()
    {
        
    }
}
