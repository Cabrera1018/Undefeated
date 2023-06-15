using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemonHealth : MonoBehaviour
{
	public int totalHealth = 100;
	public GameObject E1;
	public GameObject E2;

	public GameObject E3;

	public GameObject E4;

	public GameObject E5;

	public GameObject E6;
	public GameObject E7;
	public GameObject E8;

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

		if (health <= 80) {
				 E1.SetActive(true);
		}
		if (health <= 60) {
				 E2.SetActive(true);
				 E3.SetActive(true);
		}
		if (health <= 40) {
				 E4.SetActive(true);
				 E5.SetActive(true);
		}
		if (health <= 20) {
				 E6.SetActive(true);
				 E7.SetActive(true);
				 E8.SetActive(true);

		}

		if (health <= 0) {
			health = 0;
			gameObject.SetActive(false);
			 Instantiate(Particle, transform.position, Particle.transform.rotation);
			 Gem.SetActive(true);
		}
	}
}
