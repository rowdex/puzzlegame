using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class parcayonetim : MonoBehaviour
{
    public static int kalanparca=20;
    public static int hataparca = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (kalanparca>0)
        movepiece.zamanBonusu -= Time.deltaTime;
        if (kalanparca==0)
        {
            SceneManager.LoadScene("bolumtam");
            kalanparca = 20;
        }
    }
    
}
