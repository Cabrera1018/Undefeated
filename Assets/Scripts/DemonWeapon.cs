using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject playerbulletPrefab;
  

    // Update is called once per frame
   void Start()
    {
		//Invoke("Shoot", 1f);
		//Invoke("Shoot", 2f);
		//Invoke("Shoot", 3f);
	}

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Shoot()
    {
        Instantiate(playerbulletPrefab, firePoint.position, firePoint.rotation);
    }
    

}
