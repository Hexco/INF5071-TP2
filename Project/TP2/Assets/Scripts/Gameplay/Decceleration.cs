using UnityEngine;
using System.Collections;

public class Decceleration : MonoBehaviour {
    private float speedLowerLimit = 5;

    void OnCollisionEnter(Collision other)
    {
        if(this.tag != "Laser" && Movement.gameOver == 0)
        {
			
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
