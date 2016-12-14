using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour {

	void Awake () {
		StartCoroutine ("destttroy");

	}


	IEnumerator destttroy(){
		yield return new WaitForSeconds (2);
		Destroy (this.gameObject);
	}


}
