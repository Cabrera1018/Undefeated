using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
	public int totalHealth = 3;
	public RectTransform heartUI;
    public RectTransform gameOverMenu;
	public GameObject hordes;
	  public GameObject Particle;

	private int health;
	private float heartSize = 16f;

 public GameObject gameOverUI;

  public GameObject EventSystem;

      AudioSource au;
	private SpriteRenderer _renderer;
	private Animator _animator;
	private PlayerController _controller;


	private void Awake()
	{
		_renderer = GetComponent<SpriteRenderer>();
		_animator = GetComponent<Animator>();
		_controller = GetComponent<PlayerController>();
	}

	void Start()
    {
		health = totalHealth;   
    }

	public void AddDamage(int amount)
	{
		health = health - amount;

		// Visual Feedback
		StartCoroutine("VisualFeedback");
		
		heartUI.sizeDelta = new Vector2(heartSize * health, heartSize);
		Debug.Log("Player got damaged. His current health is " + health);

		// Game  Over
		if (health <= 0) {
			health = 0;
			Destroy(gameObject);
			GameController.GameOver();
			GameOverAu();
			 Instantiate(Particle, transform.position, Particle.transform.rotation);
		}
        
		
	}

	public void AddHealth(int amount)
	{
		health = health + amount;

		// Max health
		if (health > totalHealth) {
			health = totalHealth;
		}

	    heartUI.sizeDelta = new Vector2(heartSize * health, heartSize);

		Debug.Log("Player got some life. His current health is " + health);
	}

public void GameOverAu()
    {
        au = EventSystem.GetComponent<AudioSource> ();
        if (gameOverUI.activeSelf)
        {
            au.Pause();
        }
    }
	private IEnumerator VisualFeedback()
	{
		_renderer.color = Color.red;

		yield return new WaitForSeconds(0.1f);

		_renderer.color = Color.white;
	}
}