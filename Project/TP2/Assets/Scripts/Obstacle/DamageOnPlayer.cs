using UnityEngine;
using System.Collections;

public class DamageOnPlayer : MonoBehaviour {

	public bool activateExplosion;

	IEnumerator OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
            HpBar.hpObject = GameObject.Find("HpBar");
            HpBar.decreaseHealth();
			if (activateExplosion) {
				explosion();
			}
			GameObject player = GameObject.Find ("Airship");
			for (int i = 0; i < 5; i++) {
				player.GetComponent<Renderer> ().material.color = Color.red;
				yield return new WaitForSeconds (0.1f);
				player.GetComponent<Renderer> ().material.color = Color.white;	
				yield return new WaitForSeconds (0.1f);

			}
			Destroy(this.gameObject);
        }
		else if(other.gameObject.tag != "ShieldPower" && other.gameObject.tag != "Boss" && other.gameObject.tag != "Laser") {
			Destroy (this.gameObject);
		}
	}

	void explosion(){
		GameObject explosion = Instantiate (GameplayGeneral.enemyExplosion, transform.position, transform.rotation) as GameObject;
		explosion.GetComponentInChildren<ParticleSystem> ().Play ();
	}




}
