using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour {

	// Referencia a nuestro jugador
	public GameObject jugador;

	private Vector3 offset;

	// Use this for initialization
	void Start()
	{

		offset = transform.position - jugador.transform.position;
	}
	
	// LateUpdate se llama después de que todos los Update hayan sido llamados
	void LateUpdate()
	{
		transform.position = jugador.transform.position + offset;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
