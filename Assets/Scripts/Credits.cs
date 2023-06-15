using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Credits : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine("Esperar");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
     private IEnumerator Esperar(){

            yield return new WaitForSeconds (115);
            SceneManager.LoadScene("Menu");
        }
}
