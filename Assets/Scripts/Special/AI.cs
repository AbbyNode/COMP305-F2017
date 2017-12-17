using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {
	public Transform start;
	public Transform end;
	public float speed = 5;

	private float rotateSpeed = 5;
	private Rigidbody2D rBody;

	void Start() {
		transform.position = start.position;
		rBody = this.GetComponent<Rigidbody2D>();
	}

	void Update() {
		// Rotate
		// https://answers.unity.com/questions/650460/rotating-a-2d-sprite-to-face-a-target-on-a-single.html
		Vector3 vectorToTarget = end.position - transform.position;
		float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotateSpeed);

		// Move to point
		// https://docs.unity3d.com/ScriptReference/Vector3.MoveTowards.html
		
		transform.position += transform.right * Time.deltaTime * speed;
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		Vector3 newAngle = transform.eulerAngles;
		newAngle.z += 90;
		transform.eulerAngles = newAngle;
	}
}
