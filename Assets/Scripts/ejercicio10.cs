using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio10 : MonoBehaviour
{
    public int horario;
    void Start()
    {
        int HORA_APERTURA = 10;
        int HORA_CIERRE = 18;
        
        if (horario >= HORA_APERTURA && horario <= HORA_CIERRE) 
        {
            ;
            Debug.Log("El estacionamiento esta abierto");
        }
        else if (horario< HORA_APERTURA && horario <= 0)
        {
            
            Debug.Log("El estacionamiento esta cerrado");
        }
        else if (horario > HORA_CIERRE && horario <= 24)
        {

            
            Debug.Log("El estacionamiento esta cerrado");
        }
        else if (horario < 0 || horario > 24)
        {
            Debug.Log("Ha ingresado una hora inexistente");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
