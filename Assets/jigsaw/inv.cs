using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inv : MonoBehaviour
{
    public static float invAdj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        if (gameObject.name == "yukari")
            invAdj += 2.36f;
        if (gameObject.name == "asagi")
            invAdj -= 2.36f;
    }
}
