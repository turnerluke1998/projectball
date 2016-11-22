using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelselector : MonoBehaviour {

    public static int isLocked;
    public static int isComplete;
    public GameObject lock2;
    public GameObject lock3;
    public GameObject lock4;
    public GameObject completelevelicon;
    public GameObject newlevelicon;

    // Use this for initialization
    void Start () {
        completelevelicon.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        isLocked = PlayerPrefs.GetInt("isLocked");
        isLocked = PlayerPrefs.GetInt("isLocked");
        isLocked = PlayerPrefs.GetInt("isLocked");
        isComplete = PlayerPrefs.GetInt("level1_iscomplete");
        if (isLocked >= 1)
        {
            Destroy(lock2);
            isComplete = 1;
            completelevelicon.SetActive(true);
            PlayerPrefs.SetInt("level1_iscomplete", isComplete);
        }
        if (isLocked >= 2)
        {
            Destroy(lock3);
            completelevelicon.SetActive(true);
        }
        if (isLocked >= 3)
        {
            Destroy(lock4);
            completelevelicon.SetActive(true);
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
