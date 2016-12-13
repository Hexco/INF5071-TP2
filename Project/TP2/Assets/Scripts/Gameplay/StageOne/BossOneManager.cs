using UnityEngine;
using System.Collections;

public class BossOneManager : MonoBehaviour {
	
	public GameObject boss;
	public static float life = 80;
	Animator animator;
	public RuntimeAnimatorController part1;
	public RuntimeAnimatorController part2;
	public RuntimeAnimatorController part3;
	public RuntimeAnimatorController part4;





	void Awake(){
		life = 23;
	}
	
	void Update () {
		animator = boss.GetComponent<Animator>();
		checkPart ();
	}
		

	void checkPart(){
		if (life > 60) {
			PartOne ();
		} else if (life > 40 && life <= 60) {
			PartTwo ();
		} else if (life > 20 && life <= 40) {
			PartThree ();
		} else if (life > 0 && life <= 20) {
			PartFour ();
		} else if (life <= 0) {
			BossVictoryMenu.boss1Victory = true;
			Destroy (boss);
		}
	}

	void PartOne(){
		animator.runtimeAnimatorController = part1;
	}

	void PartTwo(){
		animator.runtimeAnimatorController = part2;

	}

	void PartThree(){
		animator.runtimeAnimatorController = part3;

	}

	void PartFour(){
		animator.runtimeAnimatorController = part4;

	}
}
