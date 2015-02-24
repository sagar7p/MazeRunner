using UnityEngine;
using System.Collections;

public class RotatorC : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.transform.name == "OVRPlayerController") {
			Application.LoadLevel("Game Over");
		}
	}
}
