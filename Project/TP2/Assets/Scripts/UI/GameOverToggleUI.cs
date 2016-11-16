using UnityEngine;
using System.Collections;

public class GameOverToggleUI : MonoBehaviour {
    public GameObject panel;
    public GameObject retry;
    public GameObject quit;

	// Use this for initialization
	void Start () {
        panel.SetActive(false);
        retry.SetActive(false);
        quit.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        if(Movement.gameOver == 1)
        {
            panel.SetActive(true);
            retry.SetActive(true);
            quit.SetActive(true);
        }
    }
}
