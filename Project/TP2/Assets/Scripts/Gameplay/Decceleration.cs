using UnityEngine;
using System.Collections;

public class Decceleration : MonoBehaviour {
    void OnCollisionEnter(Collision other)
    {
        if(this.tag != "Laser")
        {

			if (true) { // Change pour false pour avoir le comportement davant
				//test
				GameObject player = GameObject.Find("Player");
				Vector3 bounceAway = new Vector3 (player.transform.position.x +2,player.transform.position.y,player.transform.position.z);

				player.transform.position = bounceAway;
				GameObject camera = GameObject.Find ("Main Camera");
				Vector3 bounceAwayCamera = new Vector3 (camera.transform.position.x + 1.75f,camera.transform.position.y,camera.transform.position.z);

				camera.transform.position = bounceAwayCamera;
				HpBar.hpObject = GameObject.Find("HpBar");
				HpBar.decreaseHealth ();


			} else {


				Movement.planeSpeed = Mathf.Floor (Movement.planeSpeed / 3);
				if (Movement.planeSpeed < 1) {
					Movement.gameOver = 1;
					EngineOver.turnOff = 1;
				}

			}
        }
    }

}
