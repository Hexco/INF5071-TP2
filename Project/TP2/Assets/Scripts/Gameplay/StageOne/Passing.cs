using UnityEngine;
using System.Collections;

public class Passing : MonoBehaviour {

	public bool left = false;
	public bool right = false;
	public float cameraMoveForce;
	float invert = -1;

	IEnumerator OnTriggerEnter(){
		GameObject camera = GameObject.Find ("Main Camera");

		if (left) {
			camera.GetComponent<Rigidbody> ().velocity = new Vector3 (invert * cameraMoveForce, 0, 0);
		} else if (right) {
			camera.GetComponent<Rigidbody> ().velocity = new Vector3 (cameraMoveForce, 0, 0);
		}
		yield return new WaitForSeconds (0.65f);
		camera.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);
	}
}
