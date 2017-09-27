using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerFixed : MonoBehaviour {

	public Transform bg;

	private Transform camTrans;

	void Start() {
		camTrans = this.transform;
		camTrans.position = new Vector3(bg.position.x, bg.position.y, camTrans.position.z);
	}
}
