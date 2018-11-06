using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour {

    int tam;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            tam++;
            GameObject.FindWithTag("Tipo_A").GetComponent<Transform>().localScale = new Vector3(tam, tam, tam);
        }
    }
}
