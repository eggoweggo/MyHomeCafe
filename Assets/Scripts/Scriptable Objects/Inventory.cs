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
        // check if ingredient inventory is 1 (only ever want one held at a time)
        if (ingredients.Count == 1) 
        {
            // swap the ingredient
            ingredients.RemoveAt(0);
            ingredients.Add(ingredientToAdd);
            Debug.Log("You just swapped the ingredient to inventory");
        } else
        {
            // otherwise just add the ingredient to inventory
            ingredients.Add(ingredientToAdd);
            Debug.Log("You just added the ingredient to inventory");
        }
    }
}

 // check if it is a different ingredient than the one you are trying to pick up
            // if(!ingredients.Contains(ingredientToAdd))
            // {
            //     // swap the ingredient
            //     ingredients.FirstOrDefault = ingredientToAdd;
            //     Debug.Log("You just swapped the ingredient in your inventory");
            // // } else if (ingredients.Contains(ingredientToAdd))
            // // {
            // //     // if you already have the same ingredient you are trying to add
            // //     ingredients.FirstOrDefault = ingredientToAdd;
            // // }

// if(Inventory.Count == 1) 
//             {
//                 // if ingredient already in inventory swap the items
//                 SwapIngredient();
//             } else 
//             {
//                 // no held ingredient/inventory empty then add item to inventory
//                 AddIngredient();
//             }
