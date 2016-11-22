using UnityEngine;
using System.Collections;

public class SpinAround : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(new Vector3(1.5f, 1.5f, 0));
    }
}
