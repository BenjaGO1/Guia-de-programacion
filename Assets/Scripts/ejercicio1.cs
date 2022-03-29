using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio1 : MonoBehaviour
{
    public int num1 = 0;
    void Start()
    {
        int num2 = num1 + 2;
        int num3 = num2 * 2;
        Debug.Log(num1 + " + 2 = " + num2);
        Debug.Log(num2 + " * 2 = " + num3);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
