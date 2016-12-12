using UnityEngine;
using System.Collections;

public class DamageOnPlayer : MonoBehaviour {

	IEnumerator OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
            HpBar.hpObject = GameObject.Find("HpBar");
            HpBar.decreaseHealth();
			GameObject player = GameObject.Find ("Airship");
				player.GetComponent<Renderer> ().material.color = Color.red;
				yield return new WaitForSeconds (0.1f);
				player.GetComponent<Renderer> ().material.color = Color.white;			       
			Destroy(this.gameObject);
        }
        else if(other.gameObject.tag != "ShieldPower" && other.gameObject.tag != "Boss") {
			Destroy (this.gameObject);
		}
	}




}
