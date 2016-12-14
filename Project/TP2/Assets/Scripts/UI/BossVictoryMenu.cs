using UnityEngine;
using System.Collections;

public class BossVictoryMenu : MonoBehaviour {


	public GameObject victoryMenu;

	public static bool boss1Victory = false;
	public static bool boss2Victory = false;
	public static bool boss3Victory = false;
	public static bool boss4Victory = false;


	 

	void Start () {
		

	}


	void Update () {
		checkBossFinish ();

	}

	void Awake(){
		victoryMenu.SetActive(false);
		boss1Victory = false;
		boss2Victory = false;
		boss3Victory = false;
		boss4Victory = false;
	}


	void checkBossFinish(){
		if (boss1Victory) {
			victoryMenu.SetActive(true);
		}else if (boss2Victory) {
			victoryMenu.SetActive(true);
		} else if (boss3Victory) {
			victoryMenu.SetActive(true);
		} else if (boss4Victory) {
			victoryMenu.SetActive(true);
		}




	}




}
