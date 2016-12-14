using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ChangeImageUpgrade : MonoBehaviour {
	public static Image leftImage;
	public static Image rightImage;
	public static Image armorImage;
	static Sprite leftSpriteOriginal;
	static Sprite rightSpriteOriginal;
	static Sprite armorSpriteOriginal;



	void Start () {
		GameObject left = GameObject.Find ("LeftImage");
		GameObject right = GameObject.Find ("RightImage");
		GameObject armor = GameObject.Find ("ArmorImage");

		leftImage = left.GetComponent<Image> ();
		rightImage = right.GetComponent<Image> ();
		armorImage = armor.GetComponent<Image> ();
		leftSpriteOriginal = leftImage.sprite;
		rightSpriteOriginal = rightImage.sprite;
		armorSpriteOriginal = armorImage.sprite;

	}
	
	// Update is called once per frame
	void Update () {
		checkUpgrade1 ();
		checkUpgrade2 ();
		checkUpgrade3 ();
	}

	void checkUpgrade1(){
		if (Player.fire1Upgrade) {
			Sprite spr = GameObject.Find ("Upgrade1Image").GetComponent<Image> ().sprite;
			leftImage.sprite = spr;
		} else {
			leftImage.sprite = leftSpriteOriginal;
		}
	}

	void checkUpgrade2(){
		if (Player.fire2Upgrade) {
			Sprite spr = GameObject.Find ("Upgrade2Image").GetComponent<Image> ().sprite;
			rightImage.sprite = spr;
		} else {
			rightImage.sprite = rightSpriteOriginal;
		}
	}

	void checkUpgrade3(){
		if (Player.bodyUpgrade) {
			Sprite spr = GameObject.Find ("UpgradeArmorImage").GetComponent<Image> ().sprite;
			armorImage.sprite = spr;
			if (Player.jetUpgrade) {
				spr = GameObject.Find ("UpgradeSpeedArmorImage").GetComponent<Image> ().sprite;
				armorImage.sprite = spr;
			}
		} else if (Player.jetUpgrade) {
			Sprite spr = GameObject.Find ("UpgradeSpeedImage").GetComponent<Image> ().sprite;
			armorImage.sprite = spr;
			if (Player.bodyUpgrade) {
				spr = GameObject.Find ("UpgradeSpeedArmorImage").GetComponent<Image> ().sprite;
				armorImage.sprite = spr;
			}

		} else {
			armorImage.sprite = armorSpriteOriginal;
		}
	}
		
}
