using UnityEngine;
using System.Collections;

public class ArrivingToBoss : MonoBehaviour {

	void OnTriggerEnter () {
		Player.moveForwardSpeed = 0;  
	}
}
