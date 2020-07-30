using System.Collections;
using System.Collections.Generic;
using System.Runtime.Hosting;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour


{
    public GameObject menu1;
    public GameObject option;

    // Start is called before the first frame update
    void Start()
    {
        menu1.SetActive(true);
        option.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play()
    {
        SceneManager.LoadScene("juego");
    }

    public void exit()
    {
        Application.Quit();
    }

    public void activeMenu()
    {
        option.SetActive(false);
        menu1.SetActive(true);
    }

    public void activeOption()
    {
        menu1.SetActive(false);
        option.SetActive(true);
    }
}
