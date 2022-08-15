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

    private void Start() 
    {
        // load in the recipe list ingredients and have default plate
        plateDisplay.sprite = currentRecipe.defaultPlateSprite;
        if(currentRecipe.recipeList.Count == 0) 
        {
            currentRecipe.loadRecipeContents();
        }
    }

    private void Update() 
    { 
        if(Input.GetKeyDown(KeyCode.E) && playerInRange) 
        {
            addIngredientToPlate();
        }
        // if recipe ingredient list is empty (added all ingredients)
        // then change plate to finished plate
        if (currentRecipe.recipeList.Count == 0)
        {
            plateDisplay.sprite = currentRecipe.recipeFinishedSprite;
        }
    }

    private void addIngredientToPlate()
    {
        // check if ingredient is one of the ones needed for the current recipe
        if(currentRecipe.recipeList.Contains(playerInventory.currentIngredient))
        {
            currentRecipe.recipeList.Remove(playerInventory.currentIngredient);
            Debug.Log("You added it to the plate and removed from the recipe list");
            playerInventory.ingredients.RemoveAt(0);
            Debug.Log("You removed the ingredient from inventory");
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player")) 
        {
            playerInRange = true;
            plate_text.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.CompareTag("Player")) 
        {
            playerInRange = false;
            plate_text.SetActive(false);
        }
    }
}
