using UnityEngine;
using System.Collections;

public class Boss3Finish : MonoBehaviour {

	void OnTriggerEnter(){
		BossVictoryMenu.boss3Victory = true;
		Save.stageThreeDone = true;

	}
}
