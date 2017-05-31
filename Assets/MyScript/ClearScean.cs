using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearScean : MonoBehaviour {
	public float timeOut;
	private float timeElapsed;
	void Update() {
		timeElapsed += Time.deltaTime;
		if(timeElapsed >= timeOut) {
			Application.LoadLevel (0);
			timeElapsed = 0.0f;
		}
	}
}
