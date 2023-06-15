using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killzone : MonoBehaviour
{
    public int damage = 2;//el porcetanje de daño que hara al jugador


    private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player")) {
			// Tell player to get hurt
			collision.SendMessageUpwards("AddDamage", damage);
		}
        if (collision.CompareTag("Enemy")) {
			// Tell player to get hurt
			collision.SendMessageUpwards("AddDamage");
    }
    }
}
