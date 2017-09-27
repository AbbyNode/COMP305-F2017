using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerFollow : MonoBehaviour {

	public Transform player;

	private Transform camTrans;

	void Start() {
		camTrans = this.transform;
	}

	void Update() {
		camTrans.position = new Vector3(player.position.x, player.position.y, camTrans.position.z);
	}
}
