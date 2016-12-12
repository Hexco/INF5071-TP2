using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ChangeImageUpgrade : MonoBehaviour {
	public static Image leftImage;
	public static Image rightImage;
	public static Image armorImage;


	void Start () {
		GameObject left = GameObject.Find ("LeftImage");
		GameObject right = GameObject.Find ("RightImage");
		GameObject armor = GameObject.Find ("ArmorImage");

		leftImage = left.GetComponent<Image> ();
		rightImage = right.GetComponent<Image> ();
		armorImage = armor.GetComponent<Image> ();

	}
	
	// Update is called once per frame
	void Update () {
		checkUpgrade1 ();
		checkUpgrade2 ();
		checkUpgrade3 ();
	}

	void checkUpgrade1(){
		if (Player.fire1Upgrade) {
			Sprite spr = GameObject.Find ("Upgrade1Image").GetComponent<Image>().sprite;
			leftImage.sprite = spr;
		}
	}

	void checkUpgrade2(){
		if (Player.fire1Upgrade) {
			Sprite spr = GameObject.Find ("Upgrade2Image").GetComponent<Image>().sprite;
			rightImage.sprite = spr;
		}
	}

	void checkUpgrade3(){
		if (Player.fire1Upgrade) {
			Sprite spr = GameObject.Find ("UpgradeArmorImage").GetComponent<Image>().sprite;
			armorImage.sprite = spr;
		}
	}
		
}
