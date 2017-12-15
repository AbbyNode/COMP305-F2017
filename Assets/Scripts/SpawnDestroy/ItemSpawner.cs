using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bounds2D {
	public float xMin;
	public float xMax;
	public float yMin;
	public float yMax;
}

public class ItemSpawner : MonoBehaviour {
	public Bounds2D bounds;
	public GameObject[] prefabs;
	public int maxItems = 30;
	public float delay = 0.1f;

	private float accumulator;

	void Start() {
		accumulator = 0;
	}

	void Update() {
		accumulator += Time.deltaTime;

		if (accumulator >= delay && this.transform.childCount <= maxItems) {
			accumulator = 0;

			float x = Random.Range(bounds.xMin, bounds.xMax);
			float y = Random.Range(bounds.yMin, bounds.yMax);

			GameObject item = prefabs[Random.Range(0, prefabs.Length)];

			Instantiate(item, new Vector3(x, y, 0), item.transform.rotation, this.transform);
		}
	}
}
