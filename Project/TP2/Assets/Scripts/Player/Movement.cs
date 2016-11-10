using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public static float speed = 1;
    public static int gameOver = 0;
    public Rigidbody player;
    public Vector3 player_movement;

    // Use this for initialization
    void Start () {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (gameOver != 1)
        {
            var player_rotation = transform.rotation;

            //Movement
            if (SystemInfo.supportsGyroscope)
            {
                print("WHAT");
            }
            else
            {
                if (Input.GetKey("w"))
                {
                    player_movement.Set(10 * speed, -8 * speed, player_movement.z);
                    transform.rotation = player_rotation * Quaternion.Euler(transform.rotation.x, transform.rotation.y, -0.25f * speed);
                }
                else if (Input.GetKey("s"))
                {
                    player_movement.Set(10 * speed, 8 * speed, player_movement.z);
                    transform.rotation = player_rotation * Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0.25f * speed);
                }
                else
                {
                    player_movement.Set(10 * speed, 0, player_movement.z);
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.identity, Time.deltaTime / (1f / speed));
                }

                if (Input.GetKey("a"))
                {
                    player_movement.Set(10 * speed, player_movement.y, 8 * speed);
                    transform.rotation = player_rotation * Quaternion.Euler(0.25f * speed, transform.rotation.y, transform.rotation.z);
                }
                else if (Input.GetKey("d"))
                {
                    player_movement.Set(10 * speed, player_movement.y, -8 * speed);
                    transform.rotation = player_rotation * Quaternion.Euler(-0.25f * speed, transform.rotation.y, transform.rotation.z);
                }
                else
                {
                    player_movement.Set(10 * speed, player_movement.y, 0);
                }
                player.velocity = player_movement;
            }
        }
        else
        {
            player.useGravity = true;
        }
    }
}
