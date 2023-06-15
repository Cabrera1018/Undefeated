using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public int damage = 1;
	private int damageReturnig = 3;

	public float speed = 2f;
	public Vector2 direction;

	public float livingTime = 3f;
	public Color initialColor = Color.white;
	public Color finalColor;

	public GameObject explosion;

	private SpriteRenderer _renderer;
	private Rigidbody2D _rigidbody;
	private float _startingTime;

	private bool _returning;

	void Awake()
	{
		_renderer = GetComponent<SpriteRenderer>();
		_rigidbody = GetComponent<Rigidbody2D>();
	}

	// Start is called before the first frame update
	void Start()
    {
		//  Save initial time
		_startingTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
		// Change bullet's color over time
		float _timeSinceStarted = Time.time - _startingTime;
		float _percentageCompleted = _timeSinceStarted / livingTime;

		
		if (_percentageCompleted >= 1f) {
			Explode();
		}
	}

	private void FixedUpdate()
	{
		//  Move object
		Vector2 movement = direction.normalized * speed;
		_rigidbody.velocity = movement; 
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (_returning == false && collision.CompareTag("Player")) {
			// Tell player to get hurt
			collision.SendMessageUpwards("AddDamage", damage);
			Explode();
		}

		if (_returning == true && collision.CompareTag("Enemy")) {

			collision.SendMessageUpwards("AddDamage", damageReturnig);
			Explode();
		}
	}

	public void AddDamage()
	{
		
		_returning = true;
		transform.Rotate(0f, 180, 0f);
		direction = direction * -1f;
	}

	public void Explode()
	{
			Destroy(gameObject);
	}
}
