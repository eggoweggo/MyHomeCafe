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
