using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //private List<Item> itemList;

    //public Inventory() 
    //{
    //    itemList = new List<Item>(); 

    //    AddItem(new Item { itemType = Item.ItemType.Defense, amount = 1 }); 
    //    AddItem(new Item { itemType = Item.ItemType.Speed, amount = 1 }); 
    //    AddItem(new Item { itemType = Item.ItemType.Star, amount = 1 }); 
    //    //Debug.Log(itemList.Count);
    //    Debug.Log("You got a Power Up!"); 
    //}

    //public void AddItem(Item item)
    //{
    //    itemList.Add(item); 
    //}

    //public List<Item> GetItemList()
    //{
    //    return itemList;
    //}
    public bool[] isFull;
    public GameObject[] slots; 
}
