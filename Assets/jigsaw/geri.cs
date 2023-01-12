using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class geri : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void oyunExit()
    {
        Application.Quit();
    }
    void OnMouseDown()
    {
        if (gameObject.name == "geri")
            SceneManager.LoadScene("levelselect");
        if (gameObject.name == "oyna")
            SceneManager.LoadScene("levelselect");
        if (gameObject.name == "exit")
            oyunExit();
    }
}
