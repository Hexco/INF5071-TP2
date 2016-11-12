using UnityEngine;
using System.Collections;

public class NikMouvementTest : MonoBehaviour {
	public float speed = 5.0f;
	public int invert = -1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		Vector3 direction = new Vector3 (horizontal,invert*vertical,0);
		Vector3 finalDirection = new Vector3 (horizontal,invert*vertical,5.0f);

		transform.localPosition += direction * speed * Time.deltaTime;
		if (horizontal != 0 || vertical != 0) {
			Quaternion rotation;
			rotation = Quaternion.RotateTowards (transform.rotation,Quaternion.LookRotation(finalDirection),Mathf.Deg2Rad*50.0f);
			transform.localRotation = new Quaternion(rotation.x,rotation.y,rotation.z,rotation.w);
		}


	}
}
