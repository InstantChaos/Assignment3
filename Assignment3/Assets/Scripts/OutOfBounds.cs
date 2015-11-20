//Source File: OutOfBounds
//Author: Franco Chong
//Date Modified: November 19, 2015
//Program Description: Restarts the level when player goes out of bounds.

using UnityEngine;
using System.Collections;

public class OutOfBounds : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Restarts the level when the player goes out of bounds
	void OnTriggerEnter(Collider otherObjects){

		if (otherObjects.CompareTag ("Player")) {
			Application.LoadLevel(Application.loadedLevel);
		}		
		
}
}

