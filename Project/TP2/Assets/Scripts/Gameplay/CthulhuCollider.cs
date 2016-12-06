using UnityEngine;
using System.Collections;

public class CthulhuCollider : MonoBehaviour {

	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = this.transform.parent.GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player") {
			//Start Animation
			anim.SetBool ("playerIn", true);
		} else {
			anim.SetBool ("playerIn", false);
		}
	}
}
