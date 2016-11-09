using UnityEngine;
using System.Collections;

public class Acceleration : MonoBehaviour {

	void Update(){
		RotatePowerUp ();
	}

    void OnTriggerEnter(Collider other)
    {
		PickUpSound ();
        Movement.speed += 1;
		Destroy (this.gameObject);
    }
		
	void RotatePowerUp(){
		this.transform.Rotate (new Vector3 (0,1.5f,0));
	}

	void PickUpSound(){
		AudioSource sound = GameObject.Find ("SpeedPickUP").GetComponent<AudioSource> ();
		sound.Play ();
	}
}
