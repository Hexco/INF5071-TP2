using UnityEngine;
using System.Collections;

public class BossTwoManager : MonoBehaviour {



	public GameObject hpHolder;
	public GameObject boss;

	public static bool bossDone = false;



	void Update () {
		checkHp ();
	}

	void checkHp(){
		if (!bossDone) {
			if (hpHolder.GetComponent<EnemyHp> ().hp <= 0) {
				bossDone = true;
				BossVictoryMenu.boss2Victory = true;
				Save.stageTwoDone = true;
				Destroy (boss.gameObject);
			}
		}
	}
}
