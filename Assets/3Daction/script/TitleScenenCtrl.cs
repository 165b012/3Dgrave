using UnityEngine;
using System.Collections;

public class TitleScenenCtrl : MonoBehaviour {

		void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
				Application.LoadLevel (2);
			}
		}
}
