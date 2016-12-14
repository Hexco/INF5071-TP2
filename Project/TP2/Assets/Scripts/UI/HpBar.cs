using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;



public class HpBar : MonoBehaviour {

	public static float maxHP = 4;
	public static float currentHP;
	static public GameObject hpObject;
	public static Image hpImage;
	public static Sprite[] sprites;


	void Start() {
		currentHP = maxHP;
		GameObject hpBar = GameObject.Find ("HpBar");
		hpImage = hpBar.GetComponent<Image> ();

	}

	static public void decreaseHealth(){

		currentHP -= 1f;

		if (currentHP <= 0) {
			setHP (0);

			Movement.gameOver = 1;
			EngineOver.turnOff = 1;

		} else {
			setHP (currentHP);

		}
	}

	static public void setHP(float hp){
		Sprite spr = null;
		if (hp == 4 && Player.bodyUpgrade){
			spr = GameObject.Find ("hp4").GetComponent<Image>().sprite;
			Player.shield.SetActive (false);
		} else if (hp == 3){
			spr = GameObject.Find ("hp3").GetComponent<Image>().sprite;

		}else if (hp == 2){
			 spr = GameObject.Find ("hp2").GetComponent<Image>().sprite;

		}else if (hp == 1){
			 spr = GameObject.Find ("hp1").GetComponent<Image>().sprite;

		}else if (hp == 0){
			 spr = GameObject.Find ("hp0").GetComponent<Image>().sprite;

		}
		hpImage.sprite = spr;
	}

	  

}
