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

	public GameObject victoryMenu;




	// Use this for initialization
	void Start () {
		victoryMenu.SetActive(false);
	}
		

	void Awake(){
		life = 80;
	}
	
	void Update () {
		animator = boss.GetComponent<Animator>();
		checkPart ();
		checkBossFinish ();

	}

	void checkBossFinish(){
		if (life <= 0) {
			Player.fire1Upgrade = true;
			victoryMenu.SetActive(true);
		}
		
	}

	void checkPart(){
		if (life > 60) {
			PartOne ();
		} else if (life > 40 && life <= 60) {
			PartTwo ();
		} else if (life > 20 && life <= 40) {
			PartThree ();
		} else if (life <= 20) {
			PartFour ();
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
