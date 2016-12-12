using UnityEngine;
using System.Collections;

public class FlashRed : MonoBehaviour {

	public GameObject theObjectYouWannaFlashRed;
	public Color colorOfObjectYouWannaFlashRed;


	void Start(){
		if (theObjectYouWannaFlashRed == null) {
			theObjectYouWannaFlashRed = GameObject.Find ("Airship");
		}

	}

	IEnumerator OnCollisionEnter(Collision other){
		Color normalColor = theObjectYouWannaFlashRed.GetComponent<Renderer> ().material.color; 
		HitSound ();
		for (int i = 0; i < 5; i++) {
			theObjectYouWannaFlashRed.GetComponent<Renderer> ().material.color = Color.red;
			yield return new WaitForSeconds (0.1f);
			theObjectYouWannaFlashRed.GetComponent<Renderer> ().material.color = Color.white;
			yield return new WaitForSeconds (0.1f);
		}

	}
	void HitSound(){
		AudioSource sound = GameObject.Find ("SpikeExplosion").GetComponent<AudioSource> ();
		sound.Play ();
	}

}
