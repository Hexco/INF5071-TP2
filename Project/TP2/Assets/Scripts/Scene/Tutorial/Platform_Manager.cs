using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Platform_Manager : MonoBehaviour {
    public Text Mobile_Text;
    public Text PC_Text;

	// Use this for initialization
	void Start () {
        if(Application.platform == RuntimePlatform.Android)
        {
            this.gameObject.GetComponent<Text>().text = Mobile_Text.text;
        }
        else
        {
            this.gameObject.GetComponent<Text>().text = PC_Text.text;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
