using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using System.Threading;

public class levelcomplete : MonoBehaviour
{
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    // Use this for initialization
    void Start()
    {
        lives.livesCount = PlayerPrefs.GetInt("Lives");
        Coin.coinCount = PlayerPrefs.GetInt("Coins");
    }

    void OnGUI()
    {
        string deathText = "" + Coin.coinCount;
        GUI.skin.box.fontSize = 120;
        GUI.Box(new Rect(Screen.width - 1000, 680, 300, 150), deathText);
    }

    void Update()
    {
        if (lives.livesCount == 1)
        {
            Destroy(Heart1);
        }
        if (lives.livesCount == 2)
        {
            Destroy(Heart1);
            Destroy(Heart2);
        }
        if (lives.livesCount == 3)
        {
            Destroy(Heart1);
            Destroy(Heart2);
            Destroy(Heart3);
        }
    }
}

