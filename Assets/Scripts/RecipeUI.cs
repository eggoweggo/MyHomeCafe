using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeUI : MonoBehaviour
{
    public GameObject recipeMaximized;
    public Text recipeTitle;
    public Text recipeText;
    public bool recipeUIOpen;
    public GameObject checkmark;
    public GameObject checkbox;
    public Recipe currentRecipe;
    


    private void Start() 
    {
        // changeIngredientText(currentRecipe);
    }

    // Update is called once per frame
    void Update()
    {
        displayRecipeUI();
    }

    private void displayRecipeUI()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            if (recipeMaximized.activeInHierarchy) 
            {
                recipeMaximized.SetActive(false);
            } else 
            {
                recipeMaximized.SetActive(true);
            }
        }
    }

    // private void changeIngredientText(currentRecipe)
    // {
    //     recipeTitle.text = currentRecipe.recipeTitleDisplay;
    // }

}
