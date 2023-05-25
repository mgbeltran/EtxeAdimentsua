using UnityEngine;
using UnityEngine.SceneManagement;

namespace NextMind.Examples
{
    /// <summary>
    /// The ExampleScenesManager is a simple component managing users input during the example scenes (discovery et calibration). 
    /// Other inputs may be added here. 
    /// </summary>
    public class ExampleScenesManager : MonoBehaviour
    {
        GameObject noDestruir;

        private void Update()
        {
            // From this scene, go back to the hub when escape is pressed.
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                ExitToHub();
            }
        }

        /// <summary>
        /// Function used to go back to hub.
        /// </summary>
        public void ExitToHub()
        {
            noDestruir = GameObject.Find("NoDestruir");
            DontDestroyOnLoad(noDestruir);
            SceneManager.LoadScene(1);

            /*var hubManager = HubManager.Instance;
            if (hubManager != null)
            {
                hubManager.BackToHubScene();
            }*/
        }
    }
}