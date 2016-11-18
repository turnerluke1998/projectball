using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {
    public static int coinCount = 0;
    public static int totalcoinCount = 0;


    void OnGUI()
    {
        string coinText = "" + coinCount;
        GUI.skin.box.fontSize = 100;
        GUI.Box(new Rect(Screen.width - 1650, 90, 190, 130), coinText);
    }

    // Use this for initialization
    void Start () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            coinCount++;
            totalcoinCount++;
            PlayerPrefs.SetInt("Total", Coin.totalcoinCount);
        }
    }
}