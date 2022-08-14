using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    public Inventory playerInventory;

    [SerializeField]
    private GameObject plate_text;
    [SerializeField]
    private GameObject plate;
    private bool playerInRange;
    public SpriteRenderer plateDisplay;
    public Recipe currentRecipe;

    public void Start() 
    {
        currentRecipe.RecipeContents();
    }

    public void changePlate()
    {
        // if(playerInventory.ingredients != null)
        // {
        //     heldIngredientSprite.sprite = playerInventory.currentIngredient.ingredientSprite;
        // }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player")) 
        {
            Debug.Log("Player in range");
            playerInRange = true;
            plate_text.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.CompareTag("Player")) 
        {
            Debug.Log("Player left range");
            playerInRange = false;
            plate_text.SetActive(false);
        }
    }
}
