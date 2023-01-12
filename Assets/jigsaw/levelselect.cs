using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelselect : MonoBehaviour
{
    
    public static int lvlsec;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {

        if (gameObject.name == "lvl1")
            lvlsec = 1;
        else if (gameObject.name == "lvl2")
            lvlsec = 2;
        else if (gameObject.name == "lvl3")
            lvlsec = 3;
        else if (gameObject.name == "lvl4")
            lvlsec = 4;
        else if (gameObject.name == "lvl5")
            lvlsec = 5;
        else if (gameObject.name == "lvl6")
            lvlsec = 6;
        else if (gameObject.name == "lvl7")
            lvlsec = 7;
        else if (gameObject.name == "lvl8")
            lvlsec = 8;
        else if (gameObject.name == "lvl9")
            lvlsec = 9;
        else if (gameObject.name == "lvl10")
            lvlsec = 10;
        else if (gameObject.name == "lvl11")
            lvlsec = 11;
        else if (gameObject.name == "lvl12")
            lvlsec = 12;
        else if (gameObject.name == "lvl13")
            lvlsec = 13;
        else if (gameObject.name == "lvl14")
            lvlsec = 14;
        else if (gameObject.name == "lvl15")
            lvlsec = 15;
        else if (gameObject.name == "lvl16")
            lvlsec = 16;
        else if (gameObject.name == "lvl17")
            lvlsec = 17;
        else if (gameObject.name == "lvl18")
            lvlsec = 18;
        else if (gameObject.name == "lvl19")
            lvlsec = 19;
        else if (gameObject.name == "lvl20")
            lvlsec = 20;
                SceneManager.LoadScene("puzzle");
        
      
        
        //string sonuc = "";
        //string sec = gameObject.name;
        //if (sec.Length > 4)
        //{
        //    sonuc = sec.Substring(3, 1);
        //}
        //else
        //{
        //   sonuc = sec.Substring(3, 2);
        //}
        //int secim = int.Parse(sonuc);
        //lvlsec = secim;
     
        

    }
    
}
