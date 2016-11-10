using UnityEngine;
using System.Collections;

public class ObstacleMouvement : MonoBehaviour {

	static bool alreadyMoved = false;
		
	// Update is called once per frame
	void Start () {
		InvokeRepeating ("caca",0.0f,2.0f);
	}

	void caca(){
		if (alreadyMoved) {
			this.transform.Translate (0,0,-10.0f);
			alreadyMoved = false;
		} else {
			this.transform.Translate (0,0,10.0f);
			alreadyMoved = true;
		}

	}
}
