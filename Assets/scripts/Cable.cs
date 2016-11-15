using UnityEngine;
using System.Collections;

public class Cable : MonoBehaviour
{
    public static int cableCount = 0;


    /*id OnGUI()
    {
        string cableText = "" + cableCount;
        GUI.skin.box.fontSize = 100;
        GUI.Box(new Rect(Screen.width - 1650, 90, 160, 130), cableText);
    }*/

    // Use this for initialization
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            if (cableCount <= 100)
            {
                cableCount++;
                //PlayerPrefs.SetString("spr_cable_jamie_" + coll.gameObject, "Name of Cable: " + coll.gameObject);
            }
        }
    }
}
