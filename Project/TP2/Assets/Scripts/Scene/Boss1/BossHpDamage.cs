using UnityEngine;
using System.Collections;

public class BossHpDamage : MonoBehaviour {


	void OnTriggerEnter(){
		BossOneManager.life -= 1;
		print (BossOneManager.life);
	}
}
