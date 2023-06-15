using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
     public GameObject EventSystem;
    public  bool GameOver = false;
    public  bool levelPassed = false;

     AudioSource au;

    
    // Update is called once per frame
    void Update()
    {

GameOver= GameController.GameOverb;
levelPassed= LevelComplete.levelPassed;
 au = EventSystem.GetComponent<AudioSource> ();
if (levelPassed==true )
{

    Time.timeScale = 0f;
   au.Pause();  
   
}

if (GameOver==true )
{


   au.Pause();  
   
}

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused==false && GameOver==false && levelPassed==false)
            {
                 Pause();
            }else
            {
               Resume();
            }
        }
        
    }
    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

      au = EventSystem.GetComponent<AudioSource> ();

if (GameIsPaused == false){
   au.Play();
}
   
    }


    public void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

         au = EventSystem.GetComponent<AudioSource> ();

        if (GameIsPaused == true){
   au.Pause();
}

    }

    public void LoadMenu()
    {
        GameIsPaused=false;
        LevelComplete.levelPassed=false;
        GameController.GameOverb=false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        
    }

    public void Restart()
    {
        GameIsPaused=false;
        LevelComplete.levelPassed=false;
        GameController.GameOverb=false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
       

    }

    public void QuitGame()
    {
        Debug.Log ("Quitting game...");
        Application.Quit();
    }
}

