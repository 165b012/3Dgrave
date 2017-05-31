using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTele : MonoBehaviour {
	void teleport (Vector3 pos){
		transform.position = pos;
	}
}
