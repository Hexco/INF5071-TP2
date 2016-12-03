using UnityEngine;
using System.Collections;

public class Boss_4 : MonoBehaviour {
    public GameObject shield;
    public GameObject dummy;
    public GameObject shield_power;
    public static bool boss_4 = false;

    private float hp;

    private GameObject active_shield;
    public Transform shield_location;

    private GameObject shield_power_active_00;
    public Transform shield_power_00_location;

    private GameObject shield_power_active_01;
    public Transform shield_power_01_location;

    public GameObject boss;
    public GameObject weapon;
    private GameObject weapon_shot = null;
    public Transform weapon_location;
    public Transform weapon_target;
    private bool Laser_Cool = true;

    // Use this for initialization
    void Start () {
        hp = this.gameObject.GetComponent<EnemyHp>().hp_init;
        active_shield = Instantiate(shield, shield_location.position, shield.transform.rotation) as GameObject;
        shield_power_active_00 = Instantiate(shield_power, shield_power_00_location.position, shield_power.transform.rotation) as GameObject;
        shield_power_active_01 = Instantiate(shield_power, shield_power_01_location.position, shield_power.transform.rotation) as GameObject;
    }

    // Update is called once per frame
    void Update () {
        this.gameObject.transform.LookAt(weapon_target);

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

        if ((shield_power_active_00 == null || shield_power_active_01 == null) && boss != null)
        {
            Destroy(active_shield);
            StartCoroutine(Shield_Respawn());
        }

        if (boss_4)
        {
            if (weapon_shot != null)
            {
                weapon_shot.GetComponent<Rigidbody>().AddForce(transform.forward * 8, ForceMode.VelocityChange);
            }
            else if (Laser_Cool)
            {
                Laser_Cool = false;
                StartCoroutine(Laser_CD());
            }
        }
    }

    IEnumerator Shield_Respawn()
    {
        if (!shield_power_active_00)
        {
            shield_power_active_00 = dummy;
        }

        if (!shield_power_active_01)
        {
            shield_power_active_01 = dummy;
        }

        yield return new WaitForSeconds(3.0f);
        shield_power_active_00 = Instantiate(shield_power, shield_power_00_location.position, shield_power.transform.rotation) as GameObject;
        yield return new WaitForSeconds(3.0f);
        shield_power_active_01 = Instantiate(shield_power, shield_power_01_location.position, shield_power.transform.rotation) as GameObject;

        if((shield_power_active_00 && shield_power_active_00.tag == "Destroyable") && (shield_power_active_01 && shield_power_active_01.tag == "Destroyable"))
        {
            active_shield = Instantiate(shield, shield_location.position, shield.transform.rotation) as GameObject;
        }
    }

    IEnumerator Laser_CD()
    {
        yield return new WaitForSeconds(2.0f);
        weapon_shot = Instantiate(weapon, weapon_location.position, weapon.transform.rotation) as GameObject;
        Laser_Cool = true;
    }
}
