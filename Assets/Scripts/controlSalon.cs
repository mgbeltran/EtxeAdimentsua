using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlSalon : MonoBehaviour
{
    GameObject noDestruir;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Entrando en Salon");
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

    public void SubirPersianas()
    {        /*
        noDestruir = GameObject.Find("noDestruir"); //Ojo con el GameObject. Debe de llamarse igual en todas las escenas!!!!!
        DontDestroyOnLoad(noDestruir);
        SceneManager.LoadScene(1); // numero de escena a cargar */
    }

    public void BajarPersianas()
    {
        /*noDestruir = GameObject.Find("noDestruir"); //Ojo con el GameObject. Debe de llamarse igual en todas las escenas!!!!!
        DontDestroyOnLoad(noDestruir);
        SceneManager.LoadScene(1); // numero de escena a cargar */
    }

    public void pararPersianas()
    {
        /*noDestruir = GameObject.Find("noDestruir"); //Ojo con el GameObject. Debe de llamarse igual en todas las escenas!!!!!
        DontDestroyOnLoad(noDestruir);
        SceneManager.LoadScene(1); // numero de escena a cargar */
    }

    public void escenaRelax()
    {
        /*noDestruir = GameObject.Find("noDestruir"); //Ojo con el GameObject. Debe de llamarse igual en todas las escenas!!!!!
        DontDestroyOnLoad(noDestruir);
        SceneManager.LoadScene(1); // numero de escena a cargar */
    }

    public void encenderApagarLuces()
    {
        /*noDestruir = GameObject.Find("noDestruir"); //Ojo con el GameObject. Debe de llamarse igual en todas las escenas!!!!!
        DontDestroyOnLoad(noDestruir);
        SceneManager.LoadScene(1); // numero de escena a cargar */
    }
}
