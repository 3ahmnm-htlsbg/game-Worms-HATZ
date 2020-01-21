using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public int x;
    public string text;
    
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
