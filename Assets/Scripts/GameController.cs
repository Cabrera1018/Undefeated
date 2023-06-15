using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
//nuestro score comienza en cero 

    
    public GameObject GameOverImage;
    public static bool GameOverb = false;

    public static GameController gameController = null;//


    void Awake()
    {
        gameController = this;//cuando se despierte el controlador 
    }

    // Start is called before the first frame update
    void Start()
    {
        gameController.GameOverImage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public static void GameOver()
    {


        if (gameController.GameOverImage != null)
        {
            GameOverb = true;
            gameController.GameOverImage.gameObject.SetActive(true);//texto Game Over que se habilitará 
        }
    }
    
}

