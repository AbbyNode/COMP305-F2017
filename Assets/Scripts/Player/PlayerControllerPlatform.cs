using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerPlatform : MonoBehaviour {

	public float speed = 1;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		float hMove = Input.GetAxis("Horizontal");
		float vMove = 0; // Input.GetAxis("Vertical");

		rb.velocity = new Vector2(hMove, vMove) * speed;
	}
}
