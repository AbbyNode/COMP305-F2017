using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnClick : MonoBehaviour {

	public GameObject objToSpawn;

	public float spawnDelay = 0.5f;

	private Camera cam;

	private float timeSinceSpawn = 0;

	void Start() {
		cam = this.GetComponent<Camera>();

		timeSinceSpawn = spawnDelay;
	}

	void Update() {
		timeSinceSpawn += Time.deltaTime;

		if (timeSinceSpawn > spawnDelay && Input.GetAxis("Fire1") > 0) {
			SpawnObject();
			timeSinceSpawn = 0.0f;
		}
	}

	private void SpawnObject() {
		Vector3 cursorInWorldPos = cam.ScreenToWorldPoint(Input.mousePosition);
		Instantiate(objToSpawn, new Vector3(cursorInWorldPos.x, cursorInWorldPos.y, 0), Quaternion.identity);
	}
}
