using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorOnClick : MonoBehaviour {
	public SpriteRenderer spriteToModify;
	public Color color;

	private void OnMouseDown() {
		spriteToModify.material.color = color;
	}
}
