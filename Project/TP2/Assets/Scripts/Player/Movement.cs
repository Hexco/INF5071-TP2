using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public static float speed = 5;
    public static int gameOver = 0;
    public int invert = -1;
    private Rigidbody player;
    public Vector3 player_movement;

    // Use this for initialization
    void Start () {
        player = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (gameOver != 1)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector3 direction = new Vector3(horizontal, invert * vertical, 0);
            Vector3 finalDirection = new Vector3(horizontal, invert * vertical, 5.0f);

            transform.localPosition += direction * speed * Time.deltaTime;
            if (horizontal != 0 || vertical != 0)
            {
                Quaternion rotation;
                rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(finalDirection), Mathf.Deg2Rad * 50.0f);
                transform.localRotation = new Quaternion(rotation.x, rotation.y, rotation.z, rotation.w);
            }
        }
        else
        {
            player.useGravity = true;
        }
    }
}
