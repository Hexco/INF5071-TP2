using UnityEngine;
using System.Collections;

public class SpecialPlayerAction : MonoBehaviour {
	public GameObject player;
	Animator animator;
	public GameObject particle0;
	public GameObject particle1;
	public GameObject particle2;
	static Vector3 scaleOriginal = new Vector3(1,1,1);

	static float boostSpeed = 0;

	void Update () {
		animator = player.GetComponent<Animator> ();
		roll ();
		breaks ();
		boost ();
	}

	void boost(){
		if (Input.GetKey (KeyCode.Space)) {
			if (boostSpeed <= 10) {
				particle0.transform.localScale = new Vector3 (2,2,2);
				particle1.transform.localScale = new Vector3 (2,2,2);
				particle2.transform.localScale = new Vector3 (2,2,2);
				Player.temporaryAccelerationSpeed += 1;
				boostSpeed += 1;

			}
		} else if (Input.GetKeyUp (KeyCode.Space)) {
			particle0.transform.localScale = scaleOriginal;
			particle1.transform.localScale = scaleOriginal;
			particle2.transform.localScale = scaleOriginal;
			Player.temporaryAccelerationSpeed = 0;
			boostSpeed = 0;

		}
	}

	void breaks(){
		if (Input.GetKey (KeyCode.LeftShift)) {
			if (Player.temporaryAccelerationSpeed >= -5) {
				particle0.transform.localScale = new Vector3 (0.3f,0.3f,0.3f);
				particle1.transform.localScale = new Vector3 (0.3f,0.3f,0.3f);
				particle2.transform.localScale = new Vector3 (0.3f,0.3f,0.3f);
				Player.temporaryAccelerationSpeed -= 1;
					
			}
		} else if (Input.GetKeyUp (KeyCode.LeftShift)) {
			particle0.transform.localScale = scaleOriginal;
			particle1.transform.localScale = scaleOriginal;
			particle2.transform.localScale = scaleOriginal;
			Player.temporaryAccelerationSpeed = 0;
		}
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
