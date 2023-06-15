using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
	public int totalHealth = 3;
	public GameObject Gem;
	public Slider healthbar1;
	public Slider healthbar2;
	public Slider healthbar3;
	public Slider healthbar4;
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

		healthbar1.value = health;
		healthbar2.value = health;
		healthbar3.value = health;
		healthbar4.value = health;


		if (health <= 0) {
			health = 0;
			gameObject.SetActive(false);
			 Instantiate(Particle, transform.position, Particle.transform.rotation);
			 Gem.SetActive(true);
		}
	}
}
