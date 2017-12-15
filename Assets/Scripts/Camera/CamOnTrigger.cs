using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamOnTrigger : MonoBehaviour {

	public Camera cam;
	public int camType;

	private MonoBehaviour camController;

	private void Start() {
		switch (camType) {
			default:
			case 1:
				camController = cam.GetComponent<CameraControllerFollow>();
				break;
			case 2:
				camController = cam.GetComponent<CameraControllerFixed>();
				break;
			case 3:
				camController = cam.GetComponent<CameraControllerZoom>();
				break;
		}
	}

	private void OnTriggerEnter2D(Collider2D collision) {
		Debug.Log(camType);
		camController.enabled = true;
	}

	private void OnTriggerExit2D(Collider2D collision) {
		camController.enabled = false;
	}
}
