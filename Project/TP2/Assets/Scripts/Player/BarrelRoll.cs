using UnityEngine;
using System.Collections;

public class BarrelRoll : MonoBehaviour {
	public GameObject player;
	Animator animator;

	void FixedUpdate () {
		animator = player.GetComponent<Animator> ();
		roll ();
	}

	void roll(){
		if (animator.GetBool("doIt")) {
			print ("ici");
			animator.SetBool ("doIt", false);
		
		} else {
			if (Input.GetKey (KeyCode.E)) {
				animator.SetBool ("doIt", true);

			}
		}

	}
}
