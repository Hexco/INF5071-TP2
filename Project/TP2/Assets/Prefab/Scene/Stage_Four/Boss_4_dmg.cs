using UnityEngine;
using System.Collections;

public class Boss_4_dmg : MonoBehaviour {

    void Update()
    {
        StartCoroutine(Laser_Span());
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.rigidbody && other.rigidbody.tag == "Player")
        {
            //HpBar.decreaseHealth();
            Destroy(this.gameObject);
        }
    }

    IEnumerator Laser_Span()
    {
        yield return new WaitForSeconds(7.0f);
        if (this.gameObject)
        {
            Destroy(this.gameObject);
        }
    }
}
