using UnityEngine;
using System.Collections;

public class ArrivingToBoss : MonoBehaviour {

	void OnTriggerEnter () {
		Movement.moveForwardSpeed = 0;  
	}
}
