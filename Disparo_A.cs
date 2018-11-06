using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_A : MonoBehaviour {

	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
            Disparos.intensidadDisparos--;
            GameObject.FindWithTag("Tipo_A").GetComponent<Transform>().localScale = new Vector3(Disparos.intensidadDisparos,Disparos.intensidadDisparos ,Disparos.intensidadDisparos);
	}
}
