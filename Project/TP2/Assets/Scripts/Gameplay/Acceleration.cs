using UnityEngine;
using System.Collections;

public class Acceleration : MonoBehaviour {

	void Update(){
		RotatePowerUp();
	}

    void OnTriggerEnter(Collider other)
    {
        Movement.speed += 2;
		Destroy (this.gameObject);
    }
		
	void RotatePowerUp(){
		this.transform.Rotate (new Vector3 (0,1.5f,0));
	}
}
