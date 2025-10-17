using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorController : MonoBehaviour {

	// Variable RigidBody para controlar el movimiento del jugador
	private Rigidbody rb;

	// Velocidad de movimiento del jugador
	public float speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		// Obtener entrada del usuario
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		// Crear vector de movimiento
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		// Aplicar fuerza al RigidBody para mover el jugador
		rb.AddForce(movement * speed);
	}																		
}
