using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {
    
    void OnTriggerEnter(Collider other)
    {
        if(other.tag != "Player" && other.tag == "Destroyable")
        {
            if (other.gameObject.GetComponent<EnemyHp>().hp == 0)
            {
                Destroy(other.gameObject);
            } else
            {
                other.gameObject.GetComponent<EnemyHp>().hp -= 1;
            }
        }

        if(other.tag != "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
