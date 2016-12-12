using UnityEngine;
using System.Collections;

public class ArrivingToBoss : MonoBehaviour {
    public bool stage_1;
    public bool stage_2;
    public bool stage_3;
    public bool stage_4;

    void OnTriggerEnter (Collider other) {
        if (other.tag == "Player")
        {
            if (stage_4)
            {
                Boss_4.boss_4 = true;
            }
            Player.moveForwardSpeed = 0;
        }
    }
}
