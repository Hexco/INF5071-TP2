using UnityEngine;
using System.Collections;

public class ObstacleMoveLeft : MonoBehaviour {
    public float delay = 0;
    public float startDelay = 0;
    private bool alreadyMoved = false;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("MoveLeft", startDelay, delay);
    }

    void MoveLeft()
    {
        if (alreadyMoved)
        {
            this.transform.Translate(0, 0, -10.0f);
            alreadyMoved = false;
        }
        else
        {
            this.transform.Translate(0, 0, 10.0f);
            alreadyMoved = true;
        }

    }
}
