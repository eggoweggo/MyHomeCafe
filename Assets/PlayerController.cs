using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Takes and handles input and movement for a player character
public class PlayerController : MonoBehaviour
{   
    Vector2 movementInput;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    private void FixedUpdate() {
        // If movement input is not zero, try to move
        if(movementInput != Vector2.ZERO){

        }
    }

    void OnMove(InputValue movementValue) {
        movementInput = movementValue.Get<Vector2>();
    }
}
