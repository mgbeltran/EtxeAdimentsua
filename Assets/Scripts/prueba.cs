using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class prueba : MonoBehaviour
{
     public mqtt _mqtt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pulsado()
    {
        Debug.Log("Pulsado");
        _mqtt.Publish("Salon/Radio", "ON");
    }
    public void mantenido()
    {
        Debug.Log("mantenido");
    }
    public void soltado()
    {
        Debug.Log("soltado");
    }
    public void hola()
    {
        Debug.Log("HOLA");
    }
   
}
