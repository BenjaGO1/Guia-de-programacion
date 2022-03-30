using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio9 : MonoBehaviour
{
    public string nom1;
    public string nom2;
    public string nom3;

    public int capital1;
    public int capital2;
    public int capital3;
    void Start()
    {
        int capitaltot = capital1 + capital2 + capital3;
        int porcentaje1 = capital1 * 100 / capitaltot;
        int porcentaje2 = capital2 * 100 / capitaltot; 
        int porcentaje3 = capital3 * 100 / capitaltot;
        Debug.Log("Se aportaron " + capitaltot + " pesos en total");
        Debug.Log("La persona 1 aporto "+capital1+ " pesos, aporto un "+ porcentaje1+ "% del capital total");
        Debug.Log("La persona 2 aporto " + capital2 + " pesos, aporto un " + porcentaje2 + "% del capital total");
        Debug.Log("La persona 3 aporto " + capital3 + " pesos, aporto un " + porcentaje3 + "% del capital total");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
