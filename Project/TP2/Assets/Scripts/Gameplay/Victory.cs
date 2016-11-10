using UnityEngine;
using System.Collections;

public class Victory : ChangeScene {

    void Update()
    {
        RotatePowerUp();
    }

    void OnTriggerEnter(Collider other)
    {
        ChangeToScene(0);
    }

    void RotatePowerUp()
    {
        this.transform.Rotate(new Vector3(0, 1.5f, 0));
    }
}
