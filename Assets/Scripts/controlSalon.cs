using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlSalon : MonoBehaviour
{
    GameObject noDestruir;
    private UnityEngine.UI.Image image;
    public GameObject neuroTagBombiEncendida;
    public GameObject neuroTagBombiApagada;
    private static bool isLucesEncendidas = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Entrando en Salon");
        isLucesEncendidas = true;
        if (isLucesEncendidas){
            encenderLuz();
        }
        else{
            apagarLuz();
        }
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

    public void encenderLuz(){
        neuroTagBombiEncendida.SetActive(true);
        neuroTagBombiApagada.SetActive(false);
    }

    public void apagarLuz(){
        neuroTagBombiEncendida.SetActive(false);
        neuroTagBombiApagada.SetActive(true);
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
        Debug.Log("Parar persianas");
        //image = GetComponent<UnityEngine.UI.Image>();
       
    }

    public void escenaRelax()
    {
        /*noDestruir = GameObject.Find("noDestruir"); //Ojo con el GameObject. Debe de llamarse igual en todas las escenas!!!!!
        DontDestroyOnLoad(noDestruir);
        SceneManager.LoadScene(1); // numero de escena a cargar */
    }

    public void encenderLuces()
    {
        encenderLuz();
        /*noDestruir = GameObject.Find("noDestruir"); //Ojo con el GameObject. Debe de llamarse igual en todas las escenas!!!!!
        DontDestroyOnLoad(noDestruir);
        SceneManager.LoadScene(1); // numero de escena a cargar */
    }

    public void apagarLuces()
    {
        apagarLuz();
        /*noDestruir = GameObject.Find("noDestruir"); //Ojo con el GameObject. Debe de llamarse igual en todas las escenas!!!!!
        DontDestroyOnLoad(noDestruir);
        SceneManager.LoadScene(1); // numero de escena a cargar */
    }
}
