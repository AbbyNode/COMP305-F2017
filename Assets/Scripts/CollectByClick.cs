using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectByClick : MonoBehaviour {
	private void OnMouseDown() {
		CollectItems.GlobalInstance.CollectedItem(this.gameObject);
		Destroy(this.gameObject);
	}
}
