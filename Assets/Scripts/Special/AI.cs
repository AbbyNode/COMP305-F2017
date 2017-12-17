using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {
	public Transform start;
	public Transform end;
	public float speed = 5;

	private float rotateSpeed;

	void Start() {
		rotateSpeed = speed * 10;
		transform.position = start.position;
	}

	void Update() {
		// Move to point
		// https://docs.unity3d.com/ScriptReference/Vector3.MoveTowards.html
		float step = speed * Time.deltaTime;
		transform.position = Vector2.MoveTowards(transform.position, end.position, step);

		// Rotate
		// https://answers.unity.com/questions/650460/rotating-a-2d-sprite-to-face-a-target-on-a-single.html
		Vector3 vectorToTarget = end.position - transform.position;
		float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotateSpeed);
	}
}
