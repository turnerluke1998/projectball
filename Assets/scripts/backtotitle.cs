using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class backtotitle : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
            SceneManager.LoadScene("titlescreen");
    }
}