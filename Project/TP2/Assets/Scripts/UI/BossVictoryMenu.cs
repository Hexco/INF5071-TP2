using UnityEngine;
using System.Collections;

public class BossVictoryMenu : MonoBehaviour {


	public GameObject victoryMenu;

	public static bool boss1Victory = false;
	public static bool boss2Victory = false;
	public static bool boss3Victory = false;
	public static bool boss4Victory = false;


	 

	void Start () {
		victoryMenu.SetActive(false);
	}


	void Update () {
		checkBossFinish ();

	}


	void checkBossFinish(){
		if (boss1Victory) {
			whichUpgrade (1);
			victoryMenu.SetActive(true);
		}else if (boss2Victory) {
			whichUpgrade (2);
			victoryMenu.SetActive(true);
		} else if (boss3Victory) {
			whichUpgrade (3);
			victoryMenu.SetActive(true);
		} else if (boss4Victory) {
			whichUpgrade (4);
			victoryMenu.SetActive(true);
		}




	}

	void whichUpgrade(int upgrade){
		if (upgrade == 1) {
			Player.fire1Upgrade = true;
		} else if (upgrade == 2) {

		} else if (upgrade == 3) {

		} else if (upgrade == 4) {
			Player.fire2Upgrade = true;
		}
	}


}
