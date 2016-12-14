using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	
	// Update is called once per frame
	public void ChangeToScene (int sceneID) {
        SceneManager.LoadScene(sceneID);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
