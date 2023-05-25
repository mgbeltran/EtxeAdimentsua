using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pasoPantalla : MonoBehaviour
{
    GameObject noDestruir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Salimos de la aplicacion si pulsamos escape
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void PasaPantalla()
    {
        
        noDestruir = GameObject.Find("noDestruir"); //Ojo con el GameObject. Debe de llamarse igual en todas las escenas!!!!!
        DontDestroyOnLoad(noDestruir);
        SceneManager.LoadScene(1); // numero de escena a cargar 
    }

    public void PasaMenuPrincipal()
    {
        noDestruir = GameObject.Find("noDestruir"); //Ojo con el GameObject. Debe de llamarse igual en todas las escenas!!!!!
        DontDestroyOnLoad(noDestruir);
        SceneManager.LoadScene(1); // numero de escena a cargar 
    }

    public void PasaCocina()
    {

        noDestruir = GameObject.Find("noDestruir"); //Ojo con el GameObject. Debe de llamarse igual en todas las escenas!!!!!
        DontDestroyOnLoad(noDestruir);
        SceneManager.LoadScene(2); // numero de escena a cargar 
    }

    public void PasaSalon()
    {

        noDestruir = GameObject.Find("noDestruir"); //Ojo con el GameObject. Debe de llamarse igual en todas las escenas!!!!!
        DontDestroyOnLoad(noDestruir);
        SceneManager.LoadScene(3); // numero de escena a cargar 
    }

    public void PasaPlanta()
    {

        noDestruir = GameObject.Find("noDestruir"); //Ojo con el GameObject. Debe de llamarse igual en todas las escenas!!!!!
        DontDestroyOnLoad(noDestruir);
        SceneManager.LoadScene(1); // numero de escena a cargar 
    }
}
