using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.SimpleLocalization;

public class MultiLanguage : MonoBehaviour
{

    private void Awake(){
        
        /*LocalizationManager.Read();

        LocalizationManager.Language = "Castellano";
        */

    }

    public void Language(string idioma)
    {
        LocalizationManager.Language = idioma;
    }
}
