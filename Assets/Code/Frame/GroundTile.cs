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
        if (other.gameObject.tag == "Player" )
        {
        groundSpawner.SpawnGTile();
        // 10 seconds
        Destroy(gameObject, 10);
        }
        
    }

    private void Update()
    {
        
    }
}
