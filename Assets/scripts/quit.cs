using UnityEngine;
using System.Collections;

public class quitcontroller : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
            Coin.coinCount = 0;
            Application.Quit();

    }
    public void quitbutton(bool quitTheGame)
    {
        Coin.coinCount = 0;
        Application.Quit();

    }
}