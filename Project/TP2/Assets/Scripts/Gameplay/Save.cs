using UnityEngine;
using System.Collections;

public class Save : MonoBehaviour {

	public static bool stageOneDone = false;
	public static bool stageTwoDone = false;
	public static bool stageThreeDone = false;
	public static bool stageFourDone = false;

	GameObject stage1;
	GameObject stage2;
	GameObject stage3;
	GameObject stage4;



	void Awake () {
		stage1 = GameObject.Find ("Stage 1");
		stage2 = GameObject.Find ("Stage 2");
		stage3 = GameObject.Find ("Stage 3");
		stage4 = GameObject.Find ("Stage 4");
		checkStageDone (stageOneDone, stage1);
		checkStageDone (stageTwoDone, stage2);
		checkStageDone (stageThreeDone, stage3);
		checkStageDone (stageFourDone, stage4);
			
	}

	void checkStageDone(bool stageDone,GameObject stage){
		if (stageDone)
			stage.SetActive (false);
	}
}
