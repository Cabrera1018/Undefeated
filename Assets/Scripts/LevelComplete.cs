using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
 public static bool levelPassed = false;
    public GameObject LevelCompleted1;
    public GameObject LevelCompleted2;
    public GameObject LevelCompleted3;
    public GameObject LevelCompleted4;

    public string NextLevel;



	private SpriteRenderer _rederer;
	private Collider2D _collider;

	private void Awake()
	{
		_rederer = GetComponent<SpriteRenderer>();
		_collider = GetComponent<Collider2D>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player")) {
        levelPassed = true;
        LevelCompleted1.SetActive(true);
        LevelCompleted2.SetActive(true);
        LevelCompleted3.SetActive(true);
        LevelCompleted4.SetActive(true);


		}
	}

     public void LoadMenu()
    {
        levelPassed=false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

 public void Nextlevel()
    {
         Time.timeScale = 1f;
        levelPassed=false;
        SceneManager.LoadScene(NextLevel);
    }

    public void QuitGame()
    {
        Debug.Log ("Quitting game...");
        Application.Quit();
    }
}
  
