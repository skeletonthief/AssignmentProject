using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallaxID : MonoBehaviour
{
    // ID parallax
    // Desert   = 0
    // Forest   = 1
    // Lava     = 2
    // Wheat    = 3
    // Snow     = 4
    
    [SerializeField]
    private int _imageID;



    void Start()
    {
        
    }

    
    void Update()
    {
        switch(_imageID)
        {
            case 0:
                Debug.Log("Desert");
                break;
            case 1:
                Debug.Log("Forest");
                break;
            case 2:
                Debug.Log("Lava");
                break;
            case 3:
                Debug.Log("Wheat");
                break;
            case 4:
                Debug.Log("Snow");
                break;
        }
    }
}
