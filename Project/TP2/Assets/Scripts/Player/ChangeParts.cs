using UnityEngine;
using System.Collections;

public class ChangeParts : MonoBehaviour {

	void Awake(){
		if (Player.fire1Upgrade) {
			Upgrade1 ();

		} 
		if (Player.fire2Upgrade) {
			Upgrade2 ();

		}

		if (Player.jetUpgrade) {
			UpgradeWings ();

		}

	

	}

	static void Upgrade1(){
		GameObject upgrade1Part1 = GameObject.Find ("Upgrade1Part1");
		GameObject upgrade1Part2 = GameObject.Find ("Upgrade1Part2");
		GameObject part1 = GameObject.Find ("part1Mesh");	
		GameObject part4 = GameObject.Find ("part4Mesh");	

		changeMeshMaterial (upgrade1Part1, part1);
		changeMeshMaterial (upgrade1Part2, part4);
		changePositionRotation (upgrade1Part1, part1);
		changePositionRotation (upgrade1Part2,part4);
	}

	static void Upgrade2(){
		GameObject upgrade2Part1 = GameObject.Find ("Upgrade2Part1");
		GameObject upgrade2Part2 = GameObject.Find ("Upgrade2Part2");
		GameObject part2 = GameObject.Find ("part2Mesh");	
		GameObject part3 = GameObject.Find ("part3Mesh");	

		changeMeshMaterial (upgrade2Part1, part2);
		changeMeshMaterial (upgrade2Part2, part3);
		changePositionRotation (upgrade2Part2,part3);

	}

	static void UpgradeWings(){
		GameObject bodyUpgrade = GameObject.Find ("BodyUpgrade");
		GameObject body = GameObject.Find ("Airship");	
		changeMeshMaterial (bodyUpgrade, body);
	}


	static void changeMeshMaterial (GameObject from, GameObject to){
		to.GetComponent<MeshFilter> ().mesh = from.GetComponent<MeshFilter> ().mesh;
		to.GetComponent<MeshRenderer> ().material = from.GetComponent<MeshRenderer> ().material;
	}

	static void changePositionRotation(GameObject from, GameObject to){
		to.transform.localPosition = from.transform.localPosition;
		to.transform.localRotation = from.transform.localRotation;
	}
		

	public void upgrades(int upgrade){
				if (upgrade == 1) {
					Player.fire1Upgrade = true;
				} else if (upgrade == 2) {
					Player.bodyUpgrade = true;
				} else if (upgrade == 3) {
					Player.jetUpgrade = true;
				} else if (upgrade == 4) {
					Player.fire2Upgrade = true;
				}
	}
}