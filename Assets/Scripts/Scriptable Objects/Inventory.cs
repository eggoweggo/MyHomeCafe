using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Inventory : ScriptableObject
{
    public Ingredient currentIngredient;
    public List<Ingredient> ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredientToAdd)
    {
        // check if ingredient is already in inventory
        if(!ingredients.Contains(ingredientToAdd))
        {
            // add the ingredient
            ingredients.Add(ingredientToAdd);
        }
    }
}

// if(Inventory.Count == 1) 
//             {
//                 // if ingredient already in inventory swap the items
//                 SwapIngredient();
//             } else 
//             {
//                 // no held ingredient/inventory empty then add item to inventory
//                 AddIngredient();
//             }
