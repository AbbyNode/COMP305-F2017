using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LabSelector : MonoBehaviour {
	public GameObject buttonContainer;
	public GameObject buttonPrefab;
	public string[] labs;

	void Start() {
		foreach (string s in labs) {
			GameObject b = Instantiate(buttonPrefab, buttonContainer.transform);
			b.GetComponentInChildren<Button>().onClick.AddListener(() => { SceneManager.LoadScene(s); });
			b.GetComponentInChildren<Text>().text = s;
		}
	}
}
