using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public Rigidbody fireOneBullet;
	public Rigidbody fireTwoBullet;
	public Rigidbody fireOneUpgrade;
	public Rigidbody fireTwoUpgrade;
	public float velocity = 10.0f;
	float timer = 0; 
	bool soundPlayed = false;
	bool chargingSoundLoopPlayed = false;
	static Material upgrade2Color;

		void Update () {
		Fire1 ();
		Fire2 ();
	}

	void Fire1(){
		if (Input.GetButtonDown ("Fire1")) { 
			Rigidbody newBullet = Instantiate (fireOneBullet, new Vector3(transform.position.x,transform.position.y,transform.position.z), fireOneBullet.transform.rotation) as Rigidbody;
			newBullet.AddForce (transform.forward * velocity, ForceMode.VelocityChange);
		}
	}

	void Fire2(){
		if (!Player.fire2Upgrade) {
			if (Input.GetButtonDown ("Fire2")) {
				Rigidbody newBullet = Instantiate (fireTwoBullet, new Vector3 (transform.position.x, transform.position.y, transform.position.z), fireOneBullet.transform.rotation) as Rigidbody;
				newBullet.AddForce (transform.forward * velocity, ForceMode.VelocityChange);
			}
		} else {
			if (Input.GetButton ("Fire2")) {
				if (timer > 0.2f && !soundPlayed) {
					PlayUpgrade2BoostSound (true);
					soundPlayed = true;
				}
				if (timer > 2.1f) {
					if (!chargingSoundLoopPlayed) {
						PlayChargeSound (true);
						chargingSoundLoopPlayed = true;
					}
					ChangeColorUpgrade2 (true);
				}
				timer += Time.deltaTime;
			}
			if (Input.GetButtonUp ("Fire2")) {
				if (timer > 2.1f) {
					Rigidbody newBullet = Instantiate (fireTwoUpgrade, new Vector3 (transform.position.x, transform.position.y, transform.position.z), fireOneBullet.transform.rotation) as Rigidbody;
					newBullet.AddForce (transform.forward * velocity, ForceMode.VelocityChange);
					PlayChargeSound (false);
				} else {
					Rigidbody newBullet = Instantiate (fireTwoBullet, new Vector3 (transform.position.x, transform.position.y, transform.position.z), fireOneBullet.transform.rotation) as Rigidbody;
					newBullet.AddForce (transform.forward * velocity, ForceMode.VelocityChange);
					PlayUpgrade2BoostSound (false);

				}
				ChangeColorUpgrade2 (false);
				soundPlayed = false;
				chargingSoundLoopPlayed = false;
				timer = 0;
			}
		}
	}

	void ChangeColorUpgrade2(bool active){
		if (active) {
			GameObject part2 = GameObject.Find ("part2Mesh");	
			Component halo = part2.GetComponent("Halo"); 
			halo.GetType().GetProperty("enabled").SetValue(halo, true, null);

		} else if (!active) {
			GameObject part2 = GameObject.Find ("part2Mesh");	
			Component halo = part2.GetComponent("Halo"); 
			halo.GetType().GetProperty("enabled").SetValue(halo, false, null);
		}
	}

	void PlayUpgrade2BoostSound(bool play){
		AudioSource sound = GameObject.Find ("Upgrade2Boost").GetComponent<AudioSource> ();
		if (play) {
			sound.Play ();
		} else if (!play) {
			sound.Stop ();
		}	
	}

	void PlayChargeSound(bool play){
		AudioSource sound = GameObject.Find ("ChargeSound").GetComponent<AudioSource> ();
		if (play) {
			sound.Play ();
		} else if (!play) {
			sound.Stop ();
		}

	}

}
