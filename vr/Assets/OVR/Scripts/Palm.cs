using UnityEngine;
using System.Collections;

public class Palm : MonoBehaviour {

	
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.transform.name == "OVRPlayerController") {
			Application.LoadLevel("Game Over");
		}
	}
}
