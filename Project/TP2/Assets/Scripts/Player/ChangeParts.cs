using UnityEngine;
using System.Collections;

public class ChangeParts : MonoBehaviour {

	void OnTriggerEnter(){
		Upgrade1 ();
	}
	static void Upgrade1(){

		print ("cacacaca");
		GameObject upgrade1Part1 = GameObject.Find ("Upgrade1Part1");
		GameObject upgrade1Part2 = GameObject.Find ("Upgrade1Part2");
		GameObject upgrade2Part1 = GameObject.Find ("Upgrade2Part1");
		GameObject upgrade2Part2 = GameObject.Find ("Upgrade2Part2");

		GameObject part1 = GameObject.Find ("part1Mesh");	
		GameObject part4 = GameObject.Find ("part4Mesh");	
		GameObject part2 = GameObject.Find ("part2Mesh");	
		GameObject part3 = GameObject.Find ("part3Mesh");	


		part1.GetComponent<MeshFilter> ().mesh = upgrade1Part1.GetComponent<MeshFilter> ().mesh;
		part1.GetComponent<MeshRenderer> ().material = upgrade1Part1.GetComponent<MeshRenderer> ().material;

		part4.GetComponent<MeshFilter> ().mesh = upgrade1Part2.GetComponent<MeshFilter> ().mesh;
		part4.GetComponent<MeshRenderer> ().material = upgrade1Part2.GetComponent<MeshRenderer> ().material;
		part4.transform.localPosition = upgrade1Part2.transform.localPosition;
		part4.transform.localRotation = upgrade1Part2.transform.localRotation;

		part2.GetComponent<MeshFilter> ().mesh = upgrade2Part1.GetComponent<MeshFilter> ().mesh;
		part2.GetComponent<MeshRenderer> ().material = upgrade2Part1.GetComponent<MeshRenderer> ().material;

		part3.GetComponent<MeshFilter> ().mesh = upgrade2Part2.GetComponent<MeshFilter> ().mesh;
		part3.GetComponent<MeshRenderer> ().material = upgrade2Part2.GetComponent<MeshRenderer> ().material;
		part3.transform.localPosition = upgrade2Part2.transform.localPosition;
		part3.transform.localRotation = upgrade2Part2.transform.localRotation;

		Shoot.upgradeFire2 = true;
	}
}
