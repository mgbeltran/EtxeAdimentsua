using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlCocina : MonoBehaviour
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
    public void SubirEncimera()
    {        /*
        noDestruir = GameObject.Find("noDestruir"); //Ojo con el GameObject. Debe de llamarse igual en todas las escenas!!!!!
        DontDestroyOnLoad(noDestruir);
        SceneManager.LoadScene(1); // numero de escena a cargar */
    }

    public void BajarEncimera()
    {
        /*noDestruir = GameObject.Find("noDestruir"); //Ojo con el GameObject. Debe de llamarse igual en todas las escenas!!!!!
        DontDestroyOnLoad(noDestruir);
        SceneManager.LoadScene(1); // numero de escena a cargar */
    }

}
