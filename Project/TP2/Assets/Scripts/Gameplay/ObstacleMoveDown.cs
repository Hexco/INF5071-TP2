using UnityEngine;
using System.Collections;

public class ObstacleMoveDown : MonoBehaviour {
    public float delay = 0;
    private bool alreadyMoved = false;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("MoveDown", 0.0f, delay);
    }

    void MoveDown()
    {
        if (alreadyMoved)
        {
            this.transform.Translate(0, 10, 0.0f);
            alreadyMoved = false;
        }
        else
        {
            this.transform.Translate(0, -10, 0.0f);
            alreadyMoved = true;
        }

    }
}
