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

	Image myImageComponent;
	public Sprite myFirstImage; //Drag your first sprite here in inspector.
	public Sprite mySecondImage; //Drag your second sprite here in inspector.


	void Start() {
		currentHP = maxHP;
		GameObject hpBar = GameObject.Find ("HpBar");
		hpImage = hpBar.GetComponent<Image> ();


		myImageComponent = GetComponent<Image>(); //Our image component is the one attached to this gameObject.
		//Sprite[] sprites = Resources.LoadAll<Sprite> ("hp");
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
		if (hp == 3){
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
