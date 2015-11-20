//Source File: ItemPickup
//Author: Franco Chong
//Date Modified: November 19, 2015
//Program Description: Picks up items


using UnityEngine;
using System.Collections;

public class ItemPickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Destroys the coins if it collides with the player.
	void OnTriggerEnter(Collider otherCollider){
		
		if (otherCollider.gameObject.CompareTag("Player")){
			Destroy(gameObject);
		}
		
	}
}
