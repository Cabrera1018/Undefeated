using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPlayer : MonoBehaviour
{
public string Player;
    public GameObject M1;
  public GameObject M2;
  public GameObject M3;
  public GameObject M4;
  public GameObject C1;
  public GameObject C2;
  public GameObject C3;
  public GameObject C4;
  public GameObject P1;
  public GameObject P2;
  public GameObject P3;
  public GameObject P4;

void Awake (){
    Player =  Sp.v;

         if (Player == "1")
        {
            M1.SetActive(true);
            C1.SetActive(true);
            P1.SetActive(true);  

            M2.SetActive(false);
            C2.SetActive(false);
            P2.SetActive(false);

            M3.SetActive(false);
            C3.SetActive(false);
            P3.SetActive(false); 

            M4.SetActive(false);
            C4.SetActive(false);
            P4.SetActive(false);             

    }
     if (Player == "2")
        {
 M1.SetActive(false);
            C1.SetActive(false);
            P1.SetActive(false); 

            M2.SetActive(false);
            C2.SetActive(false);
            P2.SetActive(false);

            M3.SetActive(true);
            C3.SetActive(true);
            P3.SetActive(true); 

            M4.SetActive(false);
            C4.SetActive(false);
            P4.SetActive(false);   


                    

    }
     if (Player == "3")
        {
            M1.SetActive(false);
            C1.SetActive(false);
            P1.SetActive(false); 

            M2.SetActive(true);
            C2.SetActive(true);
            P2.SetActive(true); 

            M3.SetActive(false);
            C3.SetActive(false);
            P3.SetActive(false); 

            M4.SetActive(false);
            C4.SetActive(false);
            P4.SetActive(false);              

    }
     if (Player == "4")
        {
            M1.SetActive(false);
            C1.SetActive(false);
            P1.SetActive(false); 

            M2.SetActive(false);
            C2.SetActive(false);
            P2.SetActive(false);

            M3.SetActive(false);
            C3.SetActive(false);
            P3.SetActive(false); 

            M4.SetActive(true);
            C4.SetActive(true);
            P4.SetActive(true);            

    }
}
    // Start is called before the first frame update
    void Start()
    {
         M1 = GameObject.Find("Menu1");
        M2 = GameObject.Find("Menu2");
        M3 = GameObject.Find("Menu3");
        M4 = GameObject.Find("Menu4");
        C1 = GameObject.Find("Camara1");
        C2 = GameObject.Find("Camara2");
        C3 = GameObject.Find("Camara3");
        C4 = GameObject.Find("Camara4");
        P1 = GameObject.Find("Jack");
        P2 = GameObject.Find("Heather");
        P3 = GameObject.Find("Grace");
        P4 = GameObject.Find("Hiro");
    }

    // Update is called once per frame
    void Update()
    {
       
}
}