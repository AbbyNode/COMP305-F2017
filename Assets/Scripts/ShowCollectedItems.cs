using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCollectedItems : MonoBehaviour {
	public GameObject itemList;
	public GameObject itemPrefab;

	void Start() {
		Dictionary<Sprite, int> itemCount = CollectItems.GlobalInstance.itemCount;

		foreach (Sprite s in itemCount.Keys) {
			GameObject item = Instantiate(itemPrefab, itemList.transform);

			item.GetComponentInChildren<Image>().sprite = s;
			item.GetComponentInChildren<Text>().text = "" + itemCount[s];
		}
	}
}
