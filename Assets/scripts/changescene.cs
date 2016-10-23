using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour {

	// Use this for initialization
	public void changeToScene(int changeTheScene){
        SceneManager.LoadScene (changeTheScene);

    }
}
