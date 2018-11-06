using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_B : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.S))
            Disparos.intensidadDisparos++;
            GameObject.FindWithTag("Tipo_A").GetComponent<Renderer>().material.color = Color.blue;
            GameObject.FindWithTag("Tipo_B").GetComponent<Renderer>().material.color = Color.red;
    }
}
