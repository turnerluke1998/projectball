using UnityEngine;
using System.Collections;

public class quit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();

    }
    public void quitbutton(bool quitTheGame)
    {
        Application.Quit();

    }
}