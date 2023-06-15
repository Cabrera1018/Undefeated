using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class bbPlayer : MonoBehaviour
{

	private SpriteRenderer _renderer;
    public int damage = 3;
    public float speed = 20f;
	public GameObject explosion;
    public Rigidbody2D rb;
    public float _startingTime;
    public float livingTime = 3;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        _startingTime = Time.time;
    } 

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
		if (collision.CompareTag("Enemy") ) {
			collision.SendMessageUpwards("AddDamage", damage);
             Instantiate(explosion, transform.position, explosion.transform.rotation);
			Destroy(gameObject);
		}
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    public void Explode()
	{
        if (explosion) {
		 Instantiate(explosion, transform.position, explosion.transform.rotation);
		}
		Destroy(gameObject);

		
	}
}

