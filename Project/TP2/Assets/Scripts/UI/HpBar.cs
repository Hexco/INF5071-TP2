using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class HpBar : MonoBehaviour {

	public static float maxHP = 100f;
	public static float currentHP;
	static public GameObject hpObject;

	void Start() {
		currentHP = maxHP;
	}

	static public void decreaseHealth(){

		currentHP -= 1f;

		if (currentHP < 0) {
			Debug.Log ("Caca");
			setHP (0);

			Movement.gameOver = 1;
			EngineOver.turnOff = 1;

		} else {
			setHP (currentHP);

		}
	}

	static public void setHP(float hp){
		float x = hpObject.transform.localScale.x;
		float z = hpObject.transform.localScale.z;
		float y = hp / maxHP;
		hpObject.transform.localScale = new Vector3 (x,y,z);
	}

}
