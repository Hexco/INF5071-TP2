using UnityEngine;
using System.Collections;

public class Ring : MonoBehaviour {

	void Update(){
		
	}

	IEnumerator OnTriggerEnter(Collider other)
	{
		PickUpSound ();
		Movement.temporaryAccelerationSpeed += 15;
		yield return new WaitForSeconds (2.5f);
		Movement.temporaryAccelerationSpeed -= 15;

		//Destroy (this.gameObject);
	}


	void PickUpSound(){
		AudioSource sound = GameObject.Find ("RingSound").GetComponent<AudioSource> ();
		sound.Play ();
	}
}
