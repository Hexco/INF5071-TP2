using UnityEngine;
using System.Collections;

public class Ring : MonoBehaviour {

	void Update(){
		
	}

	IEnumerator OnTriggerEnter(Collider other)
	{
		PickUpSound ();
		Movement.speed += 5;
		yield return new WaitForSeconds (1.5f);
		Movement.speed -= 5;

		//Destroy (this.gameObject);
	}


	void PickUpSound(){
		AudioSource sound = GameObject.Find ("RingSound").GetComponent<AudioSource> ();
		sound.Play ();
	}
}
