using UnityEngine;
using System.Collections.Generic;


public class Obstacle : MonoBehaviour
{
	public string text;
	public bool display = false;
	void OnTriggerEnter(Collider iCollide) {
		if(iCollide.transform.name == "Player") {
			display = true;
		}
	}
	
	void OnGUI()
	{
		if (display == true) 
		{
			Application.LoadLevel("Game Over"); 
		}
	}
}
