using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bounds2D {
	public Vector2 center;
	public Vector2 extents;
}

public class ItemSpawner : MonoBehaviour {
	public Bounds2D bounds;
	public GameObject[] prefabs;
	public int maxItems;
	public float delay;

	private float 

	void Start() {

	}

	void Update() {

	}
}
