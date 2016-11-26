using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public static float planeSpeed;
	public static float moveForwardSpeed;
	public static float temporaryAccelerationSpeed;

	public static bool fire1Upgrade = false;
	public static bool fire2Upgrade = false;
	public static bool bodyUpgrade = false;
	public static bool jetUpgrade = false;

	public static bool bodyUpgradeModifierDone = false;
	public static bool jetUpgradeModifierDone = false;


	void Update(){
		BodyUpgradeModifier ();
		JetUpgradeModifier ();
	}

	void BodyUpgradeModifier(){
		if (bodyUpgrade && !bodyUpgradeModifierDone) {
			bodyUpgradeModifierDone = true;
			planeSpeed += 5;
		}
	}

	void JetUpgradeModifier(){
		//A modifier, temporaire upgrade pour le moveforward
		if (jetUpgrade && !jetUpgradeModifierDone) {
			jetUpgradeModifierDone = true;
			//moveForwardSpeed += 5;
			//Temporaire
			moveForwardSpeed += 15;
			print ("done");
		}
	}
}
