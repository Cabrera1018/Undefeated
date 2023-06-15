using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject playerbulletPrefab;
     private bool GamePaused;
     private bool Complete;
   
    public float attackRate = 2f;
    
	public float nextAttack = 0f;

    // Update is called once per frame
    void Update()
    {
        Complete= LevelComplete.levelPassed;
        GamePaused = MenuPause.GameIsPaused;

        if (Time.time >= nextAttack)
		{
			
		
        if(Input.GetButtonDown("Fire1")&& GamePaused==false&& Complete==false)
        {
            Shoot();
            	nextAttack = Time.time + 1f / attackRate;

        }
    }
    }

    void Shoot()
    {
        Instantiate(playerbulletPrefab, firePoint.position, firePoint.rotation);
    }
    

}
