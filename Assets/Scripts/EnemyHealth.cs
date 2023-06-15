using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	public int totalHealth = 3;
	public GameObject Particle;
		private int health;

void Start()
    {
		health = totalHealth;   
    }

    public void AddDamage(int amount)
	{
		health = health - amount;

		Debug.Log("Enemy got damaged. His current health is " + health);

	


		if (health <= 0) {
			health = 0;
			gameObject.SetActive(false);
			 Instantiate(Particle, transform.position, Particle.transform.rotation);
		}
	}
}
