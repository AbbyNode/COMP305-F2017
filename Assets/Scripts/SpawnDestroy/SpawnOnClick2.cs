using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnClick2 : MonoBehaviour {
	public string buttonAxis = "Fire1";
	public float spawnDelay = 1f;
	public Camera cam;
	public GameObject selectPanel;
	public GameObject[] objsToSpawn;

	private float timeSinceSpawn;
	private int selectedIndex = 0;

	void Start() {
		timeSinceSpawn = spawnDelay;

		foreach (GameObject o in objsToSpawn) {
			// Add to panel
		}
	}

	void Update() {
		timeSinceSpawn += Time.deltaTime;

		if (timeSinceSpawn > spawnDelay && Input.GetAxisRaw(buttonAxis) > 0) {
			SpawnObject();
			timeSinceSpawn = 0.0f;
		}
	}

	private void SpawnObject() {
		Vector3 cursorInWorldPos = cam.ScreenToWorldPoint(Input.mousePosition);
		cursorInWorldPos.z = 0;
		Instantiate(objsToSpawn[selectedIndex], cursorInWorldPos, Quaternion.identity, this.transform);
	}

	public void SetSelectedIndex(int newIndex) {
		selectedIndex = newIndex;
	}
}
