using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public float speed = 1;
    public Rigidbody player;
    public Vector3 player_movement;

    // Use this for initialization
    void Start () {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        var player_rotation = transform.rotation;

        //Movement
        if (SystemInfo.supportsGyroscope)
        {
            print("WHAT");
        } else
        {
            if(Input.GetKey("w"))
            {
                player_movement.Set(10 * speed, -5*speed, player_movement.z);
                transform.rotation = player_rotation * Quaternion.Euler(0,0,1);
            }
            else if (Input.GetKey("s"))
            {
                player_movement.Set(10 * speed, 5*speed, player_movement.z);
                transform.rotation = player_rotation * Quaternion.Euler(0, 0, -1);
            } else
            {
                player_movement.Set(10 * speed, 0, player_movement.z);
            }

            if (Input.GetKey("a"))
            {
                player_movement.Set(10 * speed, player_movement.y, 5 * speed);
                transform.rotation = player_rotation * Quaternion.Euler(1, 0, 0);
            }
            else if (Input.GetKey("d"))
            {
                player_movement.Set(10 * speed, player_movement.y, -5 * speed);
                transform.rotation = player_rotation * Quaternion.Euler(-1, 0, 0);
            }
            else
            {
                player_movement.Set(10 * speed, player_movement.y, 0);
            }
            player.velocity = player_movement;
        }
    }
}
