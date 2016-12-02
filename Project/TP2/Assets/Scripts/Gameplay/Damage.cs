using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Destroyable" || other.tag == "Boss")
        {
            if (other.gameObject.GetComponent<EnemyHp>().hp == 0 && other.tag == "Destroyable")
            {
                Destroy(other.gameObject);
            } else
            {
                other.gameObject.GetComponent<EnemyHp>().hp -= 1;
            }
        }

        if(other.tag != "Player" && other.tag != "Boss_Battle")
        {
            Destroy(this.gameObject);
        }
    }
}
