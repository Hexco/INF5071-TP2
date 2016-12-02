using UnityEngine;
using System.Collections;

public class Boss_4 : MonoBehaviour {
    public GameObject shield;
    public GameObject dummy;
    public GameObject shield_power;

    private float hp;

    private GameObject active_shield;
    public Transform shield_location;

    private GameObject shield_power_active_00;
    public Transform shield_power_00_location;

    private GameObject shield_power_active_01;
    public Transform shield_power_01_location;

    public GameObject boss;

    // Use this for initialization
    void Start () {
        hp = this.gameObject.GetComponent<EnemyHp>().hp_init;
        active_shield = Instantiate(shield, shield_location.position, shield.transform.rotation) as GameObject;
        shield_power_active_00 = Instantiate(shield_power, shield_power_00_location.position, shield_power.transform.rotation) as GameObject;
        shield_power_active_01 = Instantiate(shield_power, shield_power_01_location.position, shield_power.transform.rotation) as GameObject;
    }

    // Update is called once per frame
    void Update () {
        if (this.GetComponent<EnemyHp>().hp <= hp)
        {
            hp = this.GetComponent<EnemyHp>().hp;

            if (hp > 0)
            {
            }
            else
            {
                Destroy(boss);
            }
        }

        if (shield_power_active_00 == null && shield_power_active_01 == null)
        {
            Destroy(active_shield);
            StartCoroutine(Shield_Respawn());
        }      
    }

    IEnumerator Shield_Respawn()
    {
        shield_power_active_00 = dummy;
        yield return new WaitForSeconds(4.0f);
        shield_power_active_00 = Instantiate(shield_power, shield_power_00_location.position, shield_power.transform.rotation) as GameObject;
        shield_power_active_01 = Instantiate(shield_power, shield_power_01_location.position, shield_power.transform.rotation) as GameObject;
        active_shield = Instantiate(shield, shield_location.position, shield.transform.rotation) as GameObject;
    }
}
