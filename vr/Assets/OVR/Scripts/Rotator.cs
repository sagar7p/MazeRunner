using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (90, 45, 45) * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.transform.name == "CoinT") {
			Application.LoadLevel("Ending");
		}
		else if (other.gameObject.transform.name == "CoinF") {
			Application.LoadLevel("Prototype");
		}
	}

}
