using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonBullet : MonoBehaviour
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
	_rigidbody.velocity = transform.right * speed;
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
		transform.Rotate(0f, 0, 0f);  
        speed= speed*-1;
        _rigidbody.velocity = transform.right * speed;
        float localScaleX = transform.localScale.x;
		localScaleX = localScaleX * -1f;
		transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);

	}

	public void Explode()
	{
			Destroy(gameObject);
	}
}
