using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour {

	public float timeToDestroy = 1f;

	void Start() {
		Destroy(this.gameObject, timeToDestroy);
	}
}
