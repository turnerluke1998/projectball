using UnityEngine;
using System.Collections;

public class stats : MonoBehaviour {

    void OnGUI()
    {
        string coinText = "Total Coins since last level pass: " + Coin.highscorecoinCount;
        GUI.skin.box.fontSize = 50;
        GUI.Box(new Rect(Screen.width - 1200, 200, 1000, 80), coinText);
        string enemyText = "Total number of enemies killed: " + lives.enemyCount;
        GUI.skin.box.fontSize = 50;
        GUI.Box(new Rect(Screen.width - 1200, 300, 1000, 80),enemyText);
        string deathText = "Total number of deaths: " + lives.deathCount;
        GUI.skin.box.fontSize = 50;
        GUI.Box(new Rect(Screen.width - 1200, 400, 1000, 80), deathText);
        string wiresText = "Total number of Cables collected: " + Cable.cableCount + "/100";
        GUI.skin.box.fontSize = 50;
        GUI.Box(new Rect(Screen.width - 1200, 500, 1000, 80), wiresText);
        string costumesText = "Total number of Costumes obtained: "  + Gem.gemCount + "/5"; 
        GUI.skin.box.fontSize = 50;
        GUI.Box(new Rect(Screen.width - 1200, 600, 1000, 80), costumesText);
    }
    
    

    // Use this for initialization
    void Start () {
        lives.enemyCount = PlayerPrefs.GetInt("Enemies");
        lives.deathCount = PlayerPrefs.GetInt("Deaths");
        Cable.cableCount = PlayerPrefs.GetInt("Cables");
        Gem.gemCount = PlayerPrefs.GetInt("Gems");

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void clearallbutton(bool clearTheStats)
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
    }
}
