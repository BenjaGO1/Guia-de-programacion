using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio7 : MonoBehaviour
{
    public int num1 = 0;
    public int num2 = 0;
    public int num3 = 0;

    void Start()
    {
        if (num1 > num2 && num1 > num3)
        {
            Debug.Log("El mayor numero es num1");
        }
        else if (num2 > num1 && num2 > num3)
        {
            Debug.Log("El mayor numero es num2");
        }
        else if (num3 > num1 && num3 > num2)
        {
            Debug.Log("El mayor numero es num3");
        }
        else
        {
            Debug.Log("Son todos iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
