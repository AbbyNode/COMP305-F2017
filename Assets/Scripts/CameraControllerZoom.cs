using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerZoom : MonoBehaviour {

	public Transform player;
	public Transform bg;

	private Transform camTrans;
	private Camera cam;

	void Start() {
		camTrans = this.transform;
		cam = this.GetComponent<Camera>();
	}

	void Update() {
		

		float distFromLeft = player.TransformPoint(player.position).x - bg.TransformPoint(bg.position).x;
		
		Debug.Log(distFromLeft);

		camTrans.position = new Vector3(player.position.x, player.position.y, camTrans.position.z);
		cam.orthographicSize = 3 - (player.position.x / 3);
	}
}
