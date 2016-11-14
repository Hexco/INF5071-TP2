using UnityEngine;
using System.Collections;

public class ObstacleMoveRight : MonoBehaviour {
    public float delay = 0;
    private bool alreadyMoved = false;
    public float startDelay = 0;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("MoveRight", startDelay, delay);
    }

    void MoveRight()
    {
        if (alreadyMoved)
        {
            this.transform.Translate(0, 0, 10.0f);
            alreadyMoved = false;
        }
        else
        {
            this.transform.Translate(0, 0, -10.0f);
            alreadyMoved = true;
        }

    }
}
