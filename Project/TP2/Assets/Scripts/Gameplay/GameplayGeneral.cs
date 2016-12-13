using UnityEngine;
using System.Collections;

public class GameplayGeneral : MonoBehaviour {
	public GameObject enemyExplosionPrefab;
	public GameObject missileExplosionPrefab;



	public static GameObject enemyExplosion;
	public static GameObject missileExplosion;




	void Start(){
		enemyExplosion = enemyExplosionPrefab;
		missileExplosion = missileExplosionPrefab;
	}
}
