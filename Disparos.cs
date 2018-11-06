using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Disparos : MonoBehaviour {
    public InputField cartel;
    public static float intensidadDisparos;

    void LockInput(InputField entrada)
    {
        if(entrada.text.Length > 0)
        {
            intensidadDisparos = float.Parse(entrada.text);
        }else if (entrada.text.Length == 0)
        {
            Debug.Log("No hay texto");
        }
    }

    public void Start()
    {
        cartel.onEndEdit.AddListener(delegate { LockInput(cartel); });  //delegado y evento para que pille el texto 
    }

}
