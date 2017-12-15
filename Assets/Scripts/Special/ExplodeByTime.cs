using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeByTime : MonoBehaviour {

	public GameObject explosion;
	public float delay = 3f;

	private float timePassed = 0f;
	
	void Update() {
		timePassed += Time.deltaTime;

		if (timePassed >= delay) {
			Instantiate(explosion, this.transform.position, Quaternion.identity);
			Destroy(this.gameObject);
		}
	}
}
