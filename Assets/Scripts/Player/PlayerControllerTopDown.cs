using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTopDown : MonoBehaviour {
	public float speed = 1;

	private Rigidbody2D rb;

	void Start() {
		rb = this.GetComponent<Rigidbody2D>();
	}

	void Update() {
		float hMove = Input.GetAxis("Horizontal");
		float vMove = Input.GetAxis("Vertical");

		rb.velocity = new Vector2(hMove, vMove) * speed;


	}
}
