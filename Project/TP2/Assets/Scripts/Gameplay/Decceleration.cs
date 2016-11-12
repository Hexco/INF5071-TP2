using UnityEngine;
using System.Collections;

public class Decceleration : MonoBehaviour {
    void OnCollisionEnter(Collision other)
    {
        if(this.tag != "Laser")
        {
            Movement.speed = Mathf.Floor(Movement.speed / 3);
            if (Movement.speed < 1)
            {
                Movement.gameOver = 1;
                EngineOver.turnOff = 1;
            }
        }
    }
}
