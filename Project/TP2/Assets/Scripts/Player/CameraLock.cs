using UnityEngine;
using System.Collections;

public class CameraLock : MonoBehaviour {
/*
Cest encore bon ce fichier la?
*/


    public GameObject target;

	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void LateUpdate () {
        float currentRotationAngle = transform.eulerAngles.y;
        Quaternion currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);
        transform.position = target.transform.position;
        transform.position -= currentRotation * Vector3.forward * 10f;

        // Set the height of the camera
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        transform.LookAt(target.transform.position);
	}
}
