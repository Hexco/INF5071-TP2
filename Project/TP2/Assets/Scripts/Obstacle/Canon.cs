using UnityEngine;
using System.Collections;

public class Canon : MonoBehaviour {
	public GameObject fireOneBullet;
	public float velocity;
	public GameObject shootLocation;
	public float rateInSecond;


	void Start () {
		InvokeRepeating ("Shoot", 0.0f, rateInSecond);

	}

	void Shoot(){
		GameObject newBullet = Instantiate (fireOneBullet, shootLocation.transform.position, fireOneBullet.transform.rotation) as GameObject;
		newBullet.GetComponent<Rigidbody>().AddForce (shootLocation.transform.forward * velocity, ForceMode.VelocityChange);
	}
}
