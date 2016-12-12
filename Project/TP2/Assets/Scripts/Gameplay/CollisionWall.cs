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
			playerForce = Player.planeSpeed + 11;
		} else {
			playerForce = Player.planeSpeed + 11;
		}
	}


	IEnumerator OnCollisionEnter(Collision other)
	{
		GameObject player = GameObject.Find ("Player");
		GameObject camera = GameObject.Find ("Main Camera");
		float cameraForce = 0.75f;
		float invert = -1;
		Player.temporaryAccelerationSpeed = 0;
		playerForceModifier ();
		if (other.gameObject.tag == "Player") {
			
			if (Movement.gameOver == 0) {
				if (leftWall) {
					player.GetComponent<Rigidbody> ().velocity = new Vector3 (playerForce, 0, 0);
					camera.GetComponent<Rigidbody> ().velocity = new Vector3 ((cameraForce * playerForce) - 1, 0, 0);
				}
				if (rightWall) {
					player.GetComponent<Rigidbody> ().velocity = new Vector3 (invert * playerForce, 0, 0);
					camera.GetComponent<Rigidbody> ().velocity = new Vector3 (invert * (cameraForce * playerForce - 1), 0, 0);
				}
				if (TopWall) {
					player.GetComponent<Rigidbody> ().velocity = new Vector3 (0, invert * (playerForce), 0);
					camera.GetComponent<Rigidbody> ().velocity = new Vector3 (0, invert * ((cameraForce * playerForce) - 1), 0);
				}
				if (BotWall) {
					player.GetComponent<Rigidbody> ().velocity = new Vector3 (0, playerForce, 0);
					camera.GetComponent<Rigidbody> ().velocity = new Vector3 (0, (cameraForce * playerForce) - 1, 0);
				}
				if (FrontWall) {
					player.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, invert * (playerForce + 30));
					camera.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, invert * ((cameraForce * playerForce) + 32));
				}
				HpBar.hpObject = GameObject.Find ("HpBar");
				HpBar.decreaseHealth ();
				yield return new WaitForSeconds (0.15f);
				player.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);
				camera.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);
			}
		}




	}
}
