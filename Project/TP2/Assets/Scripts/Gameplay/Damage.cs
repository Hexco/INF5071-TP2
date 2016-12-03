using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {
	IEnumerator OnTriggerEnter(Collider other)
    
    {
        if (other.tag == "Destroyable" || other.tag == "Boss")
        {
            if (other.gameObject.GetComponent<EnemyHp>().hp == 0 && other.tag == "Destroyable")
            {
				DestroySound ();
                Destroy(other.gameObject);
            } else
            {
				HitSound ();
				Color normalColor = other.GetComponent<Renderer> ().material.color;
				other.GetComponent<Renderer> ().material.color = Color.red;
				yield return new WaitForSeconds (0.1f);
				other.GetComponent<Renderer> ().material.color = normalColor;
                other.gameObject.GetComponent<EnemyHp>().hp -= 1;
            }
        }

        if(other.tag != "Player" && other.tag != "Boss_Battle")
        {
            Destroy(this.gameObject);
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
