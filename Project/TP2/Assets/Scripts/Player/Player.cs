using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float forwardSpeed;

	public static float planeSpeed;
	public static float moveForwardSpeed;
	public static float temporaryAccelerationSpeed;

	public static float permanentManiabilitySpeed = 0;

	public static bool fire1Upgrade = false;
	public static bool fire2Upgrade = false;
	public static bool bodyUpgrade = false;
	public static bool jetUpgrade = false;

	public static bool bodyUpgradeModifierDone = false;
	public static bool jetUpgradeModifierDone = false;
	public static GameObject shield;

	public static Color normalColor;




	void Awake(){
		shield = GameObject.Find("AirshipShield");
		shield.SetActive (false);
		BodyUpgradeModifier ();

		print ("Current PlaneSpeed = " + planeSpeed);
		print ("Upgrade1 = " + fire1Upgrade);
		print ("Upgrade2 = " + fire2Upgrade);
		print ("UpgradeBody = " + bodyUpgrade);
		print ("UpgradeJet = " + jetUpgrade);
		print ("MaxHp = " + HpBar.maxHP);




	}

	void Update(){
		JetUpgradeModifier ();
	}
		

	void BodyUpgradeModifier(){
		if (bodyUpgrade) {
			HpBar.maxHP = 5;
			HpBar.currentHP = HpBar.maxHP;
			print (shield);
			shield.SetActive (true);
		}
	}

	void JetUpgradeModifier(){
		if (jetUpgrade && !jetUpgradeModifierDone) {
			jetUpgradeModifierDone = true;
			permanentManiabilitySpeed = 10;
		}
	}
}
