using UnityEngine;
using System.Collections;

public class Boss_4 : MonoBehaviour {
    public GameObject shield;
    public GameObject dummy;
    public GameObject shield_power;
    public Renderer renderer_4;

    public static bool boss_4 = false;
    private float laser_ID = 2;
    private float hp;

    private GameObject active_shield;
    public Transform shield_location;

    private GameObject shield_power_active_00;
    public Transform shield_power_00_location;

    private GameObject shield_power_active_01;
    public Transform shield_power_01_location;

    public GameObject boss;
    public GameObject weapon;
    public GameObject Huge_weapon;
    private GameObject weapon_shot = null;
    private GameObject Huge_weapon_shot = null;
    public Transform weapon_location;
    public Transform weapon_target;
    private bool Laser_Cool = true;
    private bool Laser_Huge_CD = true;

    // Use this for initialization
    void Start () {
        shield.GetComponent<SphereCollider>().enabled = false;
        hp = this.gameObject.GetComponent<EnemyHp>().hp_init;
        active_shield = Instantiate(shield, shield_location.position, shield.transform.rotation) as GameObject;
        active_shield.GetComponent<SphereCollider>().enabled = true;
        shield_power_active_00 = Instantiate(shield_power, shield_power_00_location.position, new Quaternion(90, 90, 0,1)) as GameObject;
        shield_power_active_01 = Instantiate(shield_power, shield_power_01_location.position, new Quaternion(90, -90, 0,1)) as GameObject;
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

        if(!shield_power_active_00 && !shield_power_active_01 && active_shield)
        {
            Destroy(active_shield);
            StartCoroutine(Shield_Respawn());
        }

        if (boss_4)
        {
            if (weapon_shot != null)
            {
                    weapon_shot.GetComponent<Rigidbody>().AddForce(transform.forward * 5, ForceMode.VelocityChange);
            }

            if (Huge_weapon_shot != null)
            {
                Huge_weapon_shot.transform.LookAt(weapon_target.position);
                Huge_weapon_shot.transform.Translate(Vector3.forward * 5);
            }

            if (Laser_Cool)
            {
                Laser_Cool = false;
                StartCoroutine(Laser_CD());
            }

            if (Laser_Huge_CD)
            {
                Laser_Huge_CD = false;
                StartCoroutine(Huge_Laser_CD());
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
        if(shield_power_active_00 && shield_power_active_00.tag != "Destroyable")
        {
            shield_power_active_00 = Instantiate(shield_power, shield_power_00_location.position, new Quaternion(90, 90, 0, 1)) as GameObject;
        }
        yield return new WaitForSeconds(3.0f);
        if (shield_power_active_01 && shield_power_active_01.tag != "Destroyable")
        {
            shield_power_active_01 = Instantiate(shield_power, shield_power_01_location.position, new Quaternion(90, -90, 0, 1)) as GameObject;
        }

        if (shield_power_active_01 && shield_power_active_00 && shield_power_active_00.tag == "Destroyable" && shield_power_active_01.tag == "Destroyable" && !active_shield)
        {
            active_shield = Instantiate(shield, shield_location.position, shield.transform.rotation) as GameObject;
            active_shield.GetComponent<SphereCollider>().enabled = true;
        }
    }

    IEnumerator Laser_CD()
    {
        yield return new WaitForSeconds(6f);
        weapon_shot = Instantiate(weapon, weapon_location.position, weapon.transform.rotation) as GameObject;
        weapon_shot.GetComponent<Rigidbody>().transform.LookAt(weapon_target.position);
        Laser_Cool = true;
    }

    IEnumerator Huge_Laser_CD()
    {
        yield return new WaitForSeconds(10f);
        Huge_weapon_shot = Instantiate(Huge_weapon, weapon_location.position, weapon.transform.rotation) as GameObject;
        Laser_Huge_CD = true;
    }
}
