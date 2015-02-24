using UnityEngine;
using System.Collections;

public class TextPanel : MonoBehaviour {

	public OVRPlayerController player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.localPosition + offset;
	}
}
