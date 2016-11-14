using UnityEngine;
using System.Collections;

public class ObstacleMoveUp : MonoBehaviour {
    public float delay = 0;
    private bool alreadyMoved = false;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("MoveUp", 0, delay);
    }

    void MoveUp()
    {
        if (alreadyMoved)
        {
            this.transform.Translate(0, -10, 0.0f);
            alreadyMoved = false;
        }
        else
        {
            this.transform.Translate(0, 10, 0.0f);
            alreadyMoved = true;
        }

    }
}
