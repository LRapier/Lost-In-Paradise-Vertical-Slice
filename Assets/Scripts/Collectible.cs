using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public string collectibleType;
    public Inventory inventory;
    public GameObject image;

    void Start()
    {
        inventory = GameObject.Find("Inventory").GetComponent<Inventory>(); 
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.GetComponent<BoxCollider2D>().sharedMaterial.name);
        if (collision.gameObject.CompareTag("Player") && collision.gameObject.GetComponent<BoxCollider2D>().sharedMaterial.name == "Feet")
        {
            if (collectibleType == "Key")
                inventory.CollectItem(image);
            else if (collectibleType == "Secret")
                inventory.CollectItem(image);
            gameObject.SetActive(false);
        }
    }
}