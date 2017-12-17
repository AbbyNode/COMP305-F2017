using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SpawnOnClick2 : MonoBehaviour {
	public float spawnDelay = 1f;
	public Camera cam;
	public GameObject selectPanel;
	public GameObject selectButtonPrefab;
	public GameObject[] objsToSpawn;

	private string buttonAxis = "Fire1";
	private float timeSinceSpawn;
	private int selectedIndex = 0;

	void Start() {
		timeSinceSpawn = spawnDelay;

		for (int i = 0; i < objsToSpawn.Length; i++) {
			GameObject button = Instantiate(selectButtonPrefab, selectPanel.transform);

			button.GetComponent<Image>().sprite = objsToSpawn[i].GetComponent<SpriteRenderer>().sprite;

			int index = i;
			button.GetComponent<Button>().onClick.AddListener(() => {
				SetSelectedIndex(index);
			});
		}
	}

	void Update() {
		timeSinceSpawn += Time.deltaTime;

		if (timeSinceSpawn > spawnDelay && Input.GetAxisRaw(buttonAxis) > 0
				&& !EventSystem.current.IsPointerOverGameObject()) {
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
