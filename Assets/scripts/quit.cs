using UnityEngine;
using System.Collections;
using System;

public class quit : MonoBehaviour
{
    void Start()
    {
        Coin.coinCount = 0;
        PlayerPrefs.SetInt("Score", Coin.coinCount);
    }
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Coin.coinCount = 0;
            Application.Quit();
        }
    }
    public void quitbutton(bool quitTheGame)
    {
        Coin.coinCount = 0;
        Application.Quit();
    }
}