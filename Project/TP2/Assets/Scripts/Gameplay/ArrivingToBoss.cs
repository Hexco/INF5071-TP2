using UnityEngine;
using System.Collections;

public class ArrivingToBoss : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
        if (other.tag == "Player")
        {
            Player.moveForwardSpeed = 0;
        }
    }
}
