using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {



	IEnumerator OnTriggerEnter(Collider other)
    
    {
        if (other)
        {
			if (this.gameObject != null && (other.tag == "Destroyable" || other.tag == "Boss" ))
            {
				if (Player.fire1Upgrade) {
					GameObject explosion = Instantiate (GameplayGeneral.missileExplosion, transform.position, transform.rotation) as GameObject;
					explosion.GetComponentInChildren<ParticleSystem> ().Play ();
				}
                other.gameObject.GetComponent<EnemyHp>().hp -= 1;
                if (other.gameObject.GetComponent<EnemyHp>().hp <= 0 && other.tag == "Destroyable")
                {
				    DestroySound ();
					GameObject explosion = Instantiate (GameplayGeneral.enemyExplosion, other.transform.position, other.transform.rotation) as GameObject;
					explosion.GetComponentInChildren<ParticleSystem> ().Play ();
                    Destroy(other.gameObject);
                } else
                {
					GameObject thisOneGonnaFlashRed;
					if (other.GetComponent<IWannaFlash> () != null) {
						thisOneGonnaFlashRed = other.GetComponent<IWannaFlash> ().iWannaFlashObject;
						thisOneGonnaFlashRed.GetComponent<Renderer> ().material.color = Color.red;
						yield return new WaitForSeconds (0.2f);
						if (other) {
							thisOneGonnaFlashRed.GetComponent<Renderer> ().material.color = Color.white;
							HitSound ();
						}
					} else {
						other.GetComponent<Renderer> ().material.color = Color.red;
						yield return new WaitForEndOfFrame ();
						if (other) {
							other.GetComponent<Renderer> ().material.color = Color.white;
							HitSound ();
						}
					}


                    
                }
            }
        }

        if (other)
        {
            if(other.tag != "Player" && other.tag != "Boss")
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
