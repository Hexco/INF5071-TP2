using UnityEngine;
using System.Collections;

public class AccelerationPowerUp : MonoBehaviour {

	void Update(){
		RotatePowerUp();
	}

    void OnTriggerEnter(Collider other)
    {
		Movement.moveForwardSpeed += 5f;
		Destroy (this.gameObject);
    }
		
	void RotatePowerUp(){
		this.transform.Rotate (new Vector3 (0,1.5f,0));
	}
}
