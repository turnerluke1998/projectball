using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelselector : MonoBehaviour {

    public static int isLocked;
    public GameObject lock2;
    public GameObject lock3;
    public GameObject lock4;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        isLocked = PlayerPrefs.GetInt("isLocked");
        isLocked = PlayerPrefs.GetInt("isLocked");
        isLocked = PlayerPrefs.GetInt("isLocked");
        if (isLocked >= 1)
        {
            Destroy(lock2);
        }
        if (isLocked >= 2)
        {
            Destroy(lock3);
        }
        if (isLocked >= 3)
        {
            Destroy(lock4);
        }
    }
    public void loadLevel1()
    {
        if (isLocked >= 0)
         SceneManager.LoadScene(5);
    }
    public void loadLevel2()
    {
        if (isLocked >= 1)
            SceneManager.LoadScene(7);
    }
}
