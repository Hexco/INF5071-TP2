using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GetArmorImage : MonoBehaviour {
	public Sprite lvl1Body;
	public Sprite lvl2Wings;
	public Sprite lvl2Shield;
	public Sprite lvl3Body;


	void OnEnable() {
		GameObject baseImage = GameObject.Find ("BaseImage");
		GameObject upgradeImage = GameObject.Find ("VictoryUpgradeImage");
		Sprite spr = lvl1Body;
		if (Player.bodyUpgrade) {
			spr = lvl2Shield;
			upgradeImage.GetComponent<Image> ().sprite = lvl3Body;
		} else if (Player.jetUpgrade){
			spr = lvl2Wings;
			upgradeImage.GetComponent<Image> ().sprite = lvl3Body;
		}
		baseImage.GetComponent<Image> ().sprite = spr;
	}

}
