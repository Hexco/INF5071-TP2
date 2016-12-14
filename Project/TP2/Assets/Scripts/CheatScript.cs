using UnityEngine;
using System.Collections;

public class CheatScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Player.planeSpeed += 15;
		Player.moveForwardSpeed += 25;
		Player.fire1Upgrade = true;
		Player.fire2Upgrade = true;
		Player.bodyUpgrade = true;
		Player.jetUpgrade = true;	
	}
	

}
