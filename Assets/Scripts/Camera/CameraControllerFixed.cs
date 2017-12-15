using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerFixed : MonoBehaviour {

	public Transform bg;

	private Transform camTrans;

	private void OnEnable() {
		camTrans = this.transform;
	}

	private void Update() {
		camTrans.position = new Vector3(bg.position.x, bg.position.y, camTrans.position.z);
	}
}
