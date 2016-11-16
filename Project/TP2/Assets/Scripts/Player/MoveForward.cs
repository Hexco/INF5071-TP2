using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

	void Update(){
		transform.position += transform.forward * (Player.moveForwardSpeed + Player.temporaryAccelerationSpeed)  * Time.deltaTime;
	}


}
