using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {
	public static float speed = 5.0f;
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * speed * Time.deltaTime;
	}
}
