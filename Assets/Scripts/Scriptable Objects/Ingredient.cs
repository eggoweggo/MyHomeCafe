using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Ingredient : ScriptableObject
{
    public Sprite ingredientSprite;
    [SerializeField]
    private string ingredientText;
}
