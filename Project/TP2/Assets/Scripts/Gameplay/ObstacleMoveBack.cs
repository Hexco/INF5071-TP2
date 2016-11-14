using UnityEngine;
using System.Collections;

public class ObstacleMoveBack : MonoBehaviour {
    public float delay = 0;
    private bool alreadyMoved = false;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("MoveBack", 0, delay);
    }

    void MoveBack()
    {
        if (alreadyMoved)
        {
            this.transform.Translate(10, 0, 0.0f);
            alreadyMoved = false;
        }
        else
        {
            this.transform.Translate(-10, 0, 0.0f);
            alreadyMoved = true;
        }

    }
}
