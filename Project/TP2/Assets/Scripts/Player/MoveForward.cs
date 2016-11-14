using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {
	// Update is called once per frame

    //SPEED est encapsuler dans movement!

	void Update () {
        if (Movement.gameOver != 1)
        {
            transform.position += transform.forward * Movement.speed * Time.deltaTime;
        }
    }
}
