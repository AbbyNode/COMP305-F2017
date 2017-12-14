using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {
	public Text text;
	public int startTime;
	public string sceneToLoad;

	private float timeLeft;

	private int prevTimeLeftInt;

	void Start() {
		timeLeft = startTime;
	}

	void Update() {
		timeLeft -= Time.deltaTime;

		int timeLeftInt = (int)timeLeft;

		if (timeLeftInt <= 0) {
			EndAction();
			return;
		}

		if (timeLeftInt != prevTimeLeftInt) {
			prevTimeLeftInt = timeLeftInt;
			text.text = "" + timeLeftInt;
		}
	}

	private void EndAction() {
		SceneManager.LoadScene(sceneToLoad);
	}
}
