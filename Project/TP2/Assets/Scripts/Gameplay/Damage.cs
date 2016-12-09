using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {
	IEnumerator OnTriggerEnter(Collider other)
    
    {
        if (other)
        {
            if (other.tag == "Destroyable" || other.tag == "Boss")
            {
                other.gameObject.GetComponent<EnemyHp>().hp -= 1;
                if (other.gameObject.GetComponent<EnemyHp>().hp <= 0 && other.tag == "Destroyable")
                {
				    DestroySound ();
                    Destroy(other.gameObject);
                } else
                {
                    HitSound();
                    Color normalColor = other.GetComponent<Renderer>().material.color;
                    other.GetComponent<Renderer>().material.color = Color.red;
                    yield return new WaitForSeconds(0.1f);
                    if (other)
                    {
                        other.GetComponent<Renderer>().material.color = normalColor;
                    }
                }
            }
        }

        if (other)
        {
            if(other.tag != "Player" && other.tag != "Boss_Battle")
            {
                Destroy(this.gameObject);
            }
        }
    }

    void HitSound(){
		AudioSource sound = GameObject.Find ("HitSound").GetComponent<AudioSource> ();
		sound.Play ();
	}

	void DestroySound(){
		AudioSource sound = GameObject.Find ("SpikeExplosion").GetComponent<AudioSource> ();
		sound.Play ();
	}


}
