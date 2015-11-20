//Source File: ChestCollision
//Author: Franco Chong
//Date Modified: November 19, 2015
//Program Description: Sets the win condition.

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChestCollision : MonoBehaviour {
	
	public Text gratzlabel;
	
	
	// Use this for initialization
	void Start () {
		
		//disables the label until conditions are met
		this.gratzlabel.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//Displays win statement.
	void OnTriggerEnter(Collider otherObjects){
		if (otherObjects.CompareTag ("Treasure")) {
			this.gratzlabel.enabled = true;

			if (Input.GetKeyDown (KeyCode.R)) {
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}
}