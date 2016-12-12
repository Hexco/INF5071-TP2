using UnityEngine;
using System.Collections;

public class EngineOver : MonoBehaviour {
    public static int turnOff = 0;
    
    void Update()
    {
		if (turnOff == 1) {
			GetComponent<ParticleSystem> ().gameObject.SetActive (false);
			//Destroy(GetComponent<ParticleSystem>());
		} else if (turnOff == 0) {
			GetComponent<ParticleSystem> ().gameObject.SetActive (true);

		}
    }
	
}
