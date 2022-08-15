using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


// Takes and handles input and movement for a player character
public class PlayerController : MonoBehaviour
{   
    public VectorValue startingPosition;
    public float moveSpeed = 1f;
    public float collisionOffset = 0.05f;
    public ContactFilter2D movementFilter;

    private Vector2 movementInput;
    private Rigidbody2D rb;
    private Animator animator;
    private List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();
    public Inventory playerInventory;
    public SpriteRenderer heldIngredientSprite;
    public Ingredient currentIngredient;

    // Start is called before the first frame update
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        transform.position = startingPosition.initialValue;
    }


    public void FixedUpdate() {
        // If movement input is not zero, try to move
        if(movementInput != Vector2.zero){
            bool success = TryMove(movementInput);

            if(!success) 
            {
                // Try left/right
                success = TryMove(new Vector2(movementInput.x, 0));

                if(!success) 
                {
                    success = TryMove( new Vector2(0, movementInput.y));
                }
            }
            animator.SetBool("isMoving", success);
        } else {
            animator.SetBool("isMoving", false);
        }
    }

    private bool TryMove(Vector2 direction) {
        // Check for potential collisions
        int count = rb.Cast(
            direction, // X and Y values between -1 and 1 that represent the direction from the body to look for collisions
            movementFilter, // The settings that determine where a collision can occur on such as layers to collide with
            castCollisions, // List of collisions to store the found collisions into after the Cast is finished
            moveSpeed * Time.fixedDeltaTime + collisionOffset); // The amount to cast equal to the movement plus the offset

        if(count == 0){
            Vector2 moveVector = direction * moveSpeed * Time.fixedDeltaTime;

            // No collisions
            rb.MovePosition(rb.position + moveVector);
            return true;
        } else {
            return false;
        }
    }

    void OnMove(InputValue movementValue) {
        movementInput = movementValue.Get<Vector2>();

        // Only set the animation direction if the player is trying to move
        if(movementInput != Vector2.zero) {
            animator.SetFloat("XInput", movementInput.x);
            animator.SetFloat("YInput", movementInput.y);
        }
    }

    public void RaiseItem()
    {
        if(playerInventory.ingredients != null)
        {
            heldIngredientSprite.sprite = playerInventory.currentIngredient.ingredientSprite;
            Debug.Log("Item sprite has changed to current ingredient in inventory");
        } 
    }
}
