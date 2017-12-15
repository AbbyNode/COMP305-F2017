using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {
	public float explosionRadius = 50f;
	public float explosionForce = 1f;

	private RaycastHit2D[] hits;

	void Start() {
		hits = Physics2D.CircleCastAll(this.transform.position, explosionRadius, Vector2.zero);

		foreach (RaycastHit2D h in hits) {
			if (h.transform.gameObject.tag == "Item")
				h.rigidbody.AddForce((h.transform.position - this.transform.position) * explosionForce, ForceMode2D.Impulse);
		}
	}
}
