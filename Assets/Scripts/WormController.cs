using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public int x;
    public string text;
    public int y;
    
    // Start is called before the first frame update
    void Start()
    {
        if (x > 0)
        {
            Debug.Log("x ist größer als 0");
        }
        else
        {
            Debug.Log("x ist nicht größer als 0");
        }

        if (text == "HATZ")
        {
            Debug.Log("Good Name, Boy!");
        }
        else
        {
            Debug.Log("Pls write good name");
        }
        if (y>10)
        {
            Debug.Log("Wert ist über 10");
        }
        else 
        {
            Debug.Log("Wert ist unter 10");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
