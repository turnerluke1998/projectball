﻿using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {

    public static int coinCount = 0;

    void OnGUI()
    {
        string coinText = "Coins: " + coinCount;
        GUI.Box(new Rect(Screen.width - 150, 20, 130, 20), coinText);
    }
}
