using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2 : MonoBehaviour
{
    public int num1 = 4;
    public int num2 = 5;
    void Start()
    {
        int num3 = num1 + num2;
        num2 = num1 - num2;
        Debug.Log("A = " + num3);
        Debug.Log("B = " + num2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
