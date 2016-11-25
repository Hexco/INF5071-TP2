using UnityEngine;
using System.Collections;

public class CollisionWall : MonoBehaviour {
	public bool leftWall = false;
	public bool rightWall = false;
	public bool TopWall= false;
	public bool BotWall = false;
	public bool FrontWall = false;
	float playerForce = 0;

	void playerForceModifier(){
		if (Player.bodyUpgrade) {
			playerForce = 21;
		} else {
			playerForce = 16;
		}
	}


	IEnumerator OnCollisionEnter(Collision other)
	{
		GameObject player = GameObject.Find("Player");
		GameObject camera = GameObject.Find ("Main Camera");
		playerForceModifier ();
		float cameraForce = 0.75f;
		float invert = -1;
		Player.temporaryAccelerationSpeed = 0;
		if (Movement.gameOver == 0) {
			if (leftWall) {
				player.GetComponent<Rigidbody> ().velocity = new Vector3 (playerForce, 0, 0);
				camera.GetComponent<Rigidbody> ().velocity = new Vector3 ((cameraForce*playerForce)-1, 0, 0);
				print ("LeftWall");
			}
			if (rightWall) {
				player.GetComponent<Rigidbody> ().velocity = new Vector3 (invert*playerForce, 0, 0);
				camera.GetComponent<Rigidbody> ().velocity = new Vector3 (invert*(cameraForce*playerForce-1), 0, 0);
				print ("rightwall");
			}
			if (TopWall) {
				player.GetComponent<Rigidbody> ().velocity = new Vector3 (0, invert*(playerForce), 0);
				camera.GetComponent<Rigidbody> ().velocity = new Vector3 (0, invert*((cameraForce*playerForce)-1), 0);
				print ("topwall");
			}
			if (BotWall) {
				player.GetComponent<Rigidbody> ().velocity = new Vector3 (0, playerForce, 0);
				camera.GetComponent<Rigidbody> ().velocity = new Vector3 (0, (cameraForce*playerForce)-1, 0);
				print ("botwall");
			}
			if (FrontWall) {
				player.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, invert*(playerForce+10));
				camera.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, invert*((cameraForce*playerForce)+12));
				print ("frontwall");
			}
			HpBar.hpObject = GameObject.Find("HpBar");
			HpBar.decreaseHealth ();
			yield return new WaitForSeconds(0.15f);
			player.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
			camera.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
		}


	}
}
