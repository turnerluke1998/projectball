using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelselector : MonoBehaviour {

    public static int isLocked;
    public static int isComplete_1;
    public static int isComplete_2;
    public static int isComplete_3;
    public static int isComplete_4;
    public GameObject lock2;
    public GameObject lock3;
    public GameObject lock4;
    public GameObject completelevelicon;
    public GameObject completelevelicon2;
    public GameObject completelevelicon3;
    public GameObject completelevelicon4;

    // Use this for initialization
    void Start () {
        completelevelicon.SetActive(false);
        completelevelicon2.SetActive(false);
        completelevelicon3.SetActive(false);
        completelevelicon4.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        isLocked = PlayerPrefs.GetInt("isLocked");
        isComplete_1 = PlayerPrefs.GetInt("level1_iscomplete");
        isComplete_2 = PlayerPrefs.GetInt("level2_iscomplete");
        isComplete_3 = PlayerPrefs.GetInt("level3_iscomplete");
        isComplete_4 = PlayerPrefs.GetInt("level4_iscomplete");
        if (isLocked >= 1)
        {
            Destroy(lock2);
            completelevelicon.SetActive(true);
            isComplete_1 = 1;
            PlayerPrefs.SetInt("level1_iscomplete", isComplete_1);
        }
        if (isLocked >= 2)
        {
            Destroy(lock3);
            completelevelicon2.SetActive(true);
            isComplete_2 = 1;
            PlayerPrefs.SetInt("level2_iscomplete", isComplete_2);
        }
        if (isLocked >= 3)
        {
            Destroy(lock4);
            completelevelicon3.SetActive(true);
            isComplete_3 = 1;
            PlayerPrefs.SetInt("level3_iscomplete", isComplete_3);
        }
        if (isLocked >= 4)
        {
            completelevelicon4.SetActive(true);
            isComplete_4 = 1;
            PlayerPrefs.SetInt("level4_iscomplete", isComplete_4);
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
    public void loadLevel3()
    {
        if (isLocked >= 2)
            SceneManager.LoadScene(9);
    }
    public void loadLevel4()
    {
        if (isLocked >= 3)
            SceneManager.LoadScene(11);
    }
}
