using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoToLevel : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()
    {

    }

    // Update is called once per frame*/
    public string total;

    
    public string entercode1;
    public string entercode2;
    void Update()
    {
total =  Node.levelCode + Passcode.SelectLevel;
entercode1 =  Passcode.enteredCode1;
entercode2 =  Passcode.enteredCode2;


    }

    public void level()
    {if (entercode1 != null && entercode2 != null)
    {
        SceneManager.LoadScene(total);
    }
        Passcode.enteredCode1 = null;
        Passcode.enteredCode2 = null;
    }
    public void jungle_level1()
    {
        SceneManager.LoadScene("31");
    }

    public void jungle_level2()
    {
        SceneManager.LoadScene("32");
    }
    public void jungle_level3()
    {
        SceneManager.LoadScene("33");
    }
    public void beach_level1()
    {
        SceneManager.LoadScene("11");
    }

    public void beach_level2()
    {
        SceneManager.LoadScene("12");
    }
    public void Beach_level3()
    {
        SceneManager.LoadScene("13");
    }
    public void cave_level1()
    {
        SceneManager.LoadScene("21");
    }

    public void cave_level2()
    {
        SceneManager.LoadScene("22");
    }
    public void cave_level3()
    {
        SceneManager.LoadScene("23");
    }
    public void volcano_level1()
    {
        SceneManager.LoadScene("41");
    }

    public void volcano_level2()
    {
        SceneManager.LoadScene("42");
    }
    public void Volcano_level3()
    {
        SceneManager.LoadScene("43");
    }

    public void Help()
    {
        SceneManager.LoadScene("Help");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Map()
    {
        SceneManager.LoadScene("SelectLevel");
    }
    public void Salir()
    {
        Application.Quit();
    }
}
