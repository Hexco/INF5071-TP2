using UnityEngine;
using System.Collections;

public class ObstacleMoveForward : MonoBehaviour {
    public float delay = 0;
    private bool alreadyMoved = false;
    public float startDelay = 0;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("MoveForward", startDelay, delay);
    }

    void MoveForward()
    {
        if (alreadyMoved)
        {
            this.transform.Translate(-10, 0, 0.0f);
            alreadyMoved = false;
        }
        else
        {
            this.transform.Translate(10, 0, 0.0f);
            alreadyMoved = true;
        }

    }
}
