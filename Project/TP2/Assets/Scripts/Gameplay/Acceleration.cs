using UnityEngine;
using System.Collections;

public class Acceleration : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        Movement.speed += 1;
    }
}
