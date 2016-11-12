using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public Rigidbody bullet;
	public float velocity = 10.0f;

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) { 
			Rigidbody newBullet = Instantiate (bullet, new Vector3(transform.position.x,transform.position.y,transform.position.z), transform.rotation) as Rigidbody;
			newBullet.AddForce (transform.forward * velocity, ForceMode.VelocityChange);
		}
	}
}
