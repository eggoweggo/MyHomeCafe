using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObject : MonoBehaviour
{
    public Inventory playerInventory;
    public Ingredient contents;
    public SignalGame raiseItem;

    [SerializeField]
    private GameObject ingredient_text;
    [SerializeField]
    private GameObject ingredient;
    private bool playerInRange;

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.E) && playerInRange) 
        {
            SwapIngredient();
            raiseItem.Raise();
        }
    }
    
    public void SwapIngredient()
    {
        // add ingredient to inventory
        playerInventory.currentIngredient = contents;
        playerInventory.AddIngredient(contents);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player")) 
        {
            Debug.Log("Player in range");
            playerInRange = true;
            ingredient_text.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.CompareTag("Player")) 
        {
            Debug.Log("Player left range");
            playerInRange = false;
            ingredient_text.SetActive(false);
        }
    }
}
