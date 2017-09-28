using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerZoom : MonoBehaviour {

	public Transform player;
	public GameObject bg;

	private Transform camTrans;
	private Camera cam;

	private float bgHalfWidth;

	void Start() {
		camTrans = this.transform;
		cam = this.GetComponent<Camera>();

		bgHalfWidth = bg.GetComponent<SpriteRenderer>().bounds.size.x / 2;
	}

	void Update() {
		float distFromLeft = player.transform.position.x - (bg.transform.position.x - bgHalfWidth);
		camTrans.position = new Vector3(player.position.x, player.position.y + Mathf.Max(2 - (distFromLeft / 5), 0), camTrans.position.z);
		cam.orthographicSize = Mathf.Clamp(3 - (distFromLeft / 5), 1, 3);
	}
}
