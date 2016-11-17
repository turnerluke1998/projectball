using UnityEngine;
using System.Collections;
using System;

public class quitcontroller : MonoBehaviour
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
            Application.Quit();
            //Coin.coinCount = 0;
            Coin.coinCount = 0;
            //System.Environment.Exit();
            //System.Diagnostics.Process.GetCurrentProcess().Kill();fff
        }
    }
    public void quitbutton(bool quitTheGame)
    {
        Application.Quit();
        //Coin.coinCount = 0;
        Coin.coinCount = 0;
        //System.Environment.Exit();
        //System.Diagnostics.Process.GetCurrentProcess().Kill();
    }
}