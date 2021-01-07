using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pan : MonoBehaviour
{
    public static Pan instance;
    //this variable contains the speed of the player
    public float moveSpeed = 5f;
    public Rigidbody2D rb; 
    //Animation Objects;
    public Animator playerAnimator; 
    // Bool variables
    public bool isDefenseAnimation; 
    public bool isDefensePowerUp; 
    // Float variables
    public float defenseTimer; 
    // Images 
    public GameObject Defense; 

    //[SerializeField] private UI_Inventory uiInventory; 
    // Restarting the inventory script due to errors 
    //private Inventory inventory; 

    // Start is called before the first frame update
    private void Start()
    {
        instance = this;
        Defense.SetActive(false);
    }

    //private void Awake()
    //{
    //    inventory = new Inventory(); 
    //    uiInventory.SetInventory(inventory);
    //}

    // Update is called once per frame
    void Update()
    {
        Jump(); 
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed; 
    }

    void Jump() 
    {
        if (Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,5f), ForceMode2D.Impulse);
        }
        
    }
}
