using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {
	// Update is called once per frame

    //SPEED est encapsuler dans movement!
	void Update(){
		transform.position += transform.forward * (Movement.moveForwardSpeed + Movement.temporaryAccelerationSpeed)  * Time.deltaTime;

	}


}
