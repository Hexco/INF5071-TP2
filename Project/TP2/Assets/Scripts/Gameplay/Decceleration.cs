using UnityEngine;
using System.Collections;

public class Decceleration : MonoBehaviour {
    private float speedLowerLimit = 5;

    IEnumerator OnCollisionEnter(Collision other)
    {
        if(this.tag != "Laser" && Movement.gameOver == 0)
        {

		
			//TEST
			Vector3 direction = other.transform.position - transform.position;
			GameObject player = GameObject.Find("Player");
			GameObject camera = GameObject.Find ("Main Camera");

			if (direction.x > 0) {
				player.GetComponent<Rigidbody> ().velocity = new Vector3 (10, 0, 0);

				camera.GetComponent<Rigidbody> ().velocity = new Vector3 (6, 0, 0);

				print ("LeftWall");
			} 
			if (direction.x < 0) {
				player.GetComponent<Rigidbody> ().velocity = new Vector3 (-10, 0, 0);

				camera.GetComponent<Rigidbody> ().velocity = new Vector3 (-6, 0, 0);

				print ("RightWall");
			}
			if (direction.y > 0) {
				player.GetComponent<Rigidbody>().velocity = new Vector3(0,13,0);

				camera.GetComponent<Rigidbody>().velocity = new Vector3(0, 9, 0);

				print ("Ground");
			} 
			if (direction.y < 0) {
				player.GetComponent<Rigidbody>().velocity = new Vector3(0,-10,0);

				camera.GetComponent<Rigidbody>().velocity = new Vector3(0, -6, 0);

				print ("Top");
			}
			
			//END TEST

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
