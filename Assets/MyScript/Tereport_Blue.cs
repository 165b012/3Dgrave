using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tereport_Blue : MonoBehaviour {
	public Vector3 porter;
	void OnTriggerEnter(Collider other) {
		Debug.Log (other.tag);
		if (other.CompareTag("Player")) {
			Debug.Log ("BBBBB");
			other.gameObject.SendMessage ("teleport", porter);
		}
	}
}
