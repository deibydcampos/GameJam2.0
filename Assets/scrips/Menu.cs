using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameObject menuP; 
    void Start()
    {
        menuP.SetActive(false);
        
    }

    
    void Update()
    {

    }
    public void SwitchPaues()
    {

    }
    public void bntResume()
    {
        menuP.SetActive(false);
        Time.timeScale = 1;

    }
    public void bntPause()
    {
        menuP.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("pause");

    }
    public void Mprincipal(string name)
    {
       SceneManager.LoadScene(name);
        Time.timeScale = 1;

    }
    public void Salir()
    {
        Debug.Log("salio");
        Application.Quit();
    }
}
