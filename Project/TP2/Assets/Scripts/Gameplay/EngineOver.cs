using UnityEngine;
using System.Collections;

public class EngineOver : MonoBehaviour {
    public static int turnOff = 0;
    
    void Update()
    {
        if (turnOff == 1)
        {
            Destroy(GetComponent<ParticleSystem>());
        }
    }
	
}
