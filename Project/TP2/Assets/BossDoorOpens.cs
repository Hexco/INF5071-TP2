using UnityEngine;
using System.Collections;

public class BossDoorOpens : MonoBehaviour {
	public RuntimeAnimatorController doorOpens;
	public GameObject door;
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player")
		{
			door.GetComponent<Animator> ().runtimeAnimatorController = doorOpens;
		}
	}
}
