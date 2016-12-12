using UnityEngine;
using System.Collections;

public class ChangeParts : MonoBehaviour {

	void OnTriggerEnter(){
		UpgradeParts ();
	}
	static void UpgradeParts(){

		GameObject upgrade1Part1 = GameObject.Find ("Upgrade1Part1");
		GameObject upgrade1Part2 = GameObject.Find ("Upgrade1Part2");
		GameObject upgrade2Part1 = GameObject.Find ("Upgrade2Part1");
		GameObject upgrade2Part2 = GameObject.Find ("Upgrade2Part2");
		GameObject bodyUpgrade = GameObject.Find ("BodyUpgrade");

		GameObject part1 = GameObject.Find ("part1Mesh");	
		GameObject part4 = GameObject.Find ("part4Mesh");	
		GameObject part2 = GameObject.Find ("part2Mesh");	
		GameObject part3 = GameObject.Find ("part3Mesh");	
		GameObject body = GameObject.Find ("Airship");	

		changeMeshMaterial (upgrade1Part1, part1);
		changeMeshMaterial (upgrade1Part2, part4);
		changeMeshMaterial (upgrade2Part1, part2);
		changeMeshMaterial (upgrade2Part2, part3);
		changeMeshMaterial (bodyUpgrade, body);

		changePositionRotation (upgrade1Part1, part1);
		changePositionRotation (upgrade1Part2,part4);
		changePositionRotation (upgrade2Part2,part3);


		Player.fire1Upgrade = true;
		Player.fire2Upgrade = true;
		Player.bodyUpgrade = true;
		Player.jetUpgrade = true;
	}



	static void changeMeshMaterial (GameObject from, GameObject to){
		to.GetComponent<MeshFilter> ().mesh = from.GetComponent<MeshFilter> ().mesh;
		to.GetComponent<MeshRenderer> ().material = from.GetComponent<MeshRenderer> ().material;
	}

	static void changePositionRotation(GameObject from, GameObject to){
		to.transform.localPosition = from.transform.localPosition;
		to.transform.localRotation = from.transform.localRotation;
	}
}