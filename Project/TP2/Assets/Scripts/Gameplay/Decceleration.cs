﻿using UnityEngine;
using System.Collections;

public class Decceleration : MonoBehaviour {
    private float speedLowerLimit = 5;
	public bool up;

    IEnumerator OnCollisionEnter(Collision other)
    {
        if(this.tag != "Laser" && Movement.gameOver == 0)
        {
			GameObject player = GameObject.Find("Player");
            player.GetComponent<Rigidbody>().velocity = new Vector3(10,0,0);

            GameObject camera = GameObject.Find ("Main Camera");
            camera.GetComponent<Rigidbody>().velocity = new Vector3(6, 0, 0);

            HpBar.hpObject = GameObject.Find("HpBar");
			HpBar.decreaseHealth ();
            yield return new WaitForSeconds(0.15f);
            player.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            camera.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);

			if(Player.planeSpeed > 5)
            {
				Player.planeSpeed = Mathf.Floor(Player.planeSpeed / 2);

				if (Player.planeSpeed < speedLowerLimit)
                {
					Player.planeSpeed = speedLowerLimit;
                }
            }
        }
    }

}
