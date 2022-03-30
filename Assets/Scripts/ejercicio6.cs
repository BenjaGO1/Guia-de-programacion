using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio6 : MonoBehaviour
{

    public int num1 = 0;

    void Start()
    {
        if (num1 % 2 == 0)
        {
            Debug.Log("El numero es par");
        }
        else
        {
            Debug.Log("El numero es impar");
        }
    }
}
