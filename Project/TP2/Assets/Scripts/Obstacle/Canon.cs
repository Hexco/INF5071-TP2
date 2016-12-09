using UnityEngine;
using System.Collections;

public class Canon : MonoBehaviour {
	public GameObject bullet;
	public float velocity;
	public GameObject shootLocation;
	public float rateInSecond;


	void Start () {
		InvokeRepeating ("Shoot", 0.0f, rateInSecond);

	}

	void Shoot(){
		GameObject newBullet = Instantiate (bullet, shootLocation.transform.position, shootLocation.transform.rotation) as GameObject;
		newBullet.GetComponent<Rigidbody>().AddForce (shootLocation.transform.forward * velocity, ForceMode.VelocityChange);
	}
}
