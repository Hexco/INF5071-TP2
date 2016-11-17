using UnityEngine;
using System.Collections;

public class EnemyHp : MonoBehaviour {
    public int hp_init = 0;
    public int hp;

	void Awake ()
    {
        hp = hp_init;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
