using UnityEngine;
using System.Collections;

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
            //Coin.coinCount = 0;
            Coin.coinCount = 0;
            Application.Quit();
            //System.Environment.Exit();
            //System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
    public void quitbutton(bool quitTheGame)
    {
        //Coin.coinCount = 0;
        Coin.coinCount = 0;
        Application.Quit();
        //System.Environment.Exit();
        //System.Diagnostics.Process.GetCurrentProcess().Kill();
    }
}