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

		rb.angularVelocity = 0;
		rb.velocity = new Vector2(0, 0);

		if (hMove != 0 || vMove != 0) {
			rb.velocity = new Vector2(hMove, vMove) * speed;
			transform.eulerAngles = new Vector3(0, 0, (Mathf.Atan2(vMove, hMove) * Mathf.Rad2Deg) - 90);
		}
	}
}
