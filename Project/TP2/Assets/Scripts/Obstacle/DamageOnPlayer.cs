using UnityEngine;
using System.Collections;

public class DamageOnPlayer : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			StartCoroutine ("FlashRed");
		} else {
			Destroy (this.gameObject);
		}
	}

	IEnumerator FlashRed(){
		GameObject player = GameObject.Find ("Airship");
		HitSound ();
		Color normalColor = player.GetComponent<Renderer> ().material.color;
		HpBar.hpObject = GameObject.Find ("HpBar");
		HpBar.decreaseHealth ();
		this.GetComponent<Renderer>().enabled = false;
		for (int i = 0; i < 5; i++) {
			player.GetComponent<Renderer> ().material.color = Color.red;
			yield return new WaitForSeconds (0.1f);
			player.GetComponent<Renderer> ().material.color = normalColor;
			yield return new WaitForSeconds (0.1f);

		}
		Destroy (this.gameObject);
	}

	void HitSound(){
		AudioSource sound = GameObject.Find ("SpikeExplosion").GetComponent<AudioSource> ();
		sound.Play ();
	}
}
