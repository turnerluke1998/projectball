﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class settings : MonoBehaviour {

    public void resetAllLevelProgress()
    {
        levelselector.isLocked = 0;
        PlayerPrefs.DeleteKey("isComplete_1");
        PlayerPrefs.DeleteKey("isComplete_2");
        PlayerPrefs.DeleteKey("isComplete_3");
        PlayerPrefs.DeleteKey("isComplete_4");
        PlayerPrefs.DeleteKey("isLocked");
        SceneManager.LoadScene(4);
    }
    public void resetAllStats()
    {
        SceneManager.LoadScene(2);
        PlayerPrefs.DeleteKey("TotalCoins");
        PlayerPrefs.DeleteKey("Coins");
        PlayerPrefs.DeleteKey("Enemies");
        PlayerPrefs.DeleteKey("Deaths");
        PlayerPrefs.DeleteKey("Cables");
        PlayerPrefs.DeleteKey("Gems");
        PlayerPrefs.DeleteKey("isComplete_1");
        PlayerPrefs.DeleteKey("isComplete_2");
        PlayerPrefs.DeleteKey("isComplete_3");
        PlayerPrefs.DeleteKey("isComplete_4");
    }
    public void resetAllData()
    {
        SceneManager.LoadScene(0);
        PlayerPrefs.DeleteKey("TotalCoins");
        PlayerPrefs.DeleteKey("Coins");
        PlayerPrefs.DeleteKey("Enemies");
        PlayerPrefs.DeleteKey("Deaths");
        PlayerPrefs.DeleteKey("Cables");
        PlayerPrefs.DeleteKey("Gems");
        levelselector.isLocked = 0;
        PlayerPrefs.DeleteKey("isLocked");
        PlayerPrefs.DeleteKey("isComplete_1");
        PlayerPrefs.DeleteKey("isComplete_2");
        PlayerPrefs.DeleteKey("isComplete_3");
        PlayerPrefs.DeleteKey("isComplete_4");
    }
}
