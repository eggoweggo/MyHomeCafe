using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Recipe : ScriptableObject 
{
    public Ingredient recipeIngredient1;
    public Ingredient recipeIngredient2;
    public Ingredient recipeIngredient3;
    public Ingredient recipeIngredient4;
    public Ingredient recipeIngredient5;
    public Sprite defaultPlateSprite;
    public Sprite recipeFinishedSprite;
    public List<Ingredient> recipeList = new List<Ingredient>();

    public void loadRecipeContents()
    {
        if (recipeIngredient1 != null)
        {
            recipeList.Add(recipeIngredient1);
            Debug.Log($"Ingredient 1 added to the recipe");
        }
        if (recipeIngredient2 != null)
        {
            recipeList.Add(recipeIngredient2);
            Debug.Log($"Ingredient 2 added to the recipe");
        }
        if (recipeIngredient3 != null)
        {
            recipeList.Add(recipeIngredient3);
            Debug.Log($"Ingredient 3 added to the recipe");
        }
        if (recipeIngredient4 != null)
        {
            recipeList.Add(recipeIngredient4);
            Debug.Log($"Ingredient 4 added to the recipe");
        }
        if (recipeIngredient5 != null)
        {
            recipeList.Add(recipeIngredient5);
            Debug.Log($"Ingredient 5 added to the recipe");
        }
        // var count = 5;
        // while(count > 0) 
        // {
        //     if (recipeIngredient != null)
        //     {
        //         // otherwise just add the ingredient to inventory
        //         recipeList.Add(recipeIngredient1);
        //         Debug.Log($"Ingredient {number} added to the recipe");
        //     }
        //     count -= 1;
        // }
    }
}

