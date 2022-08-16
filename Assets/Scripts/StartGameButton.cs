using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    public GameObject startButton;
    public GameObject mainMenu;
    // Start is called before the first frame update

    public void startGame() 
    {
        SceneManager.LoadScene("cafe scene");
    }
}
