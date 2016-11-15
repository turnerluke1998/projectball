using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class splash : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("space"))
        SceneManager.LoadScene(1);
    }
}