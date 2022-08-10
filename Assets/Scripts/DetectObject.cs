using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObject : MonoBehaviour
{
    [SerializeField]
    private GameObject ingredient_text;
    [SerializeField]
    private GameObject ingredient;
    private bool playerInRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // // var strawberry_text = GameObject.Find("strawberry_text");
        // // Input.GetKey(KeyCode.E) && 
        // if(playerInRange && !ingredient_text.activeInHierarchy)
        // {
        //     ingredient_text.SetActive(true);
        // } else 
        // {
        //     ingredient_text.SetActive(false);
        // }
    }
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player")) 
        {
            Debug.Log("Player in range");
            playerInRange = true;
            ingredient_text.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.CompareTag("Player")) 
        {
            Debug.Log("Player left range");
            playerInRange = false;
            ingredient_text.SetActive(false);
        }
    }
}
