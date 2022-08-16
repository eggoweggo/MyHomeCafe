using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeUI : MonoBehaviour
{
    public GameObject recipeMaximized;
    public Text recipeTitle;
    public string recipleTitleDisplay;
    public Text recipeText;
    public string recipeIngredientDisplay;
    public bool recipeUIOpen;
    public GameObject checkmark;
    public GameObject checkbox;


    private void Start() 
    {
        
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
                Debug.Log("UI closed");
            } else 
            {
                recipeMaximized.SetActive(true);
                Debug.Log("UI open");
            }
        }
    }

}
