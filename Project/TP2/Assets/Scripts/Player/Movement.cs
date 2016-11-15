using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public static float planeSpeed;
	public static float moveForwardSpeed;
	public static float temporaryAccelerationSpeed;
    public static int gameOver = 0;
    public int invert = -1;
    private Rigidbody player;
    public Vector3 player_movement;
	public Camera camera;


    // Use this for initialization
    void Start () {
        player = GetComponent<Rigidbody>();
    }

    void Awake()
    {
        planeSpeed = 5;
        moveForwardSpeed = 7;
        temporaryAccelerationSpeed = 0;
        gameOver = 0;
    }

    void Update()
    {
        if (gameOver != 1)
        {
            Vector3 direction = new Vector3();
			Vector3 finalDirection = new Vector3();
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
				direction = new Vector3 (horizontal, invert * vertical, 0);
				finalDirection = new Vector3 (horizontal, invert * vertical, 5.0f);

			transform.localPosition += direction * planeSpeed * Time.deltaTime;
			camera.transform.position += direction * (planeSpeed*0.75f) * Time.deltaTime;
            if (horizontal != 0 || vertical != 0)
            {
                Quaternion rotation;
                rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(finalDirection), Mathf.Deg2Rad * 50.0f);
                transform.localRotation = new Quaternion(rotation.x, rotation.y, rotation.z, rotation.w);
            }
        }
        else
        {
            player.freezeRotation = false;
            moveForwardSpeed = 0;
            player.useGravity = true;
        }
    }

	
		
		
}
