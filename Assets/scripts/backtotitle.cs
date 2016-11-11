using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class backtotitle : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Coin.coinCount = 0;
            lives.livesCount = 0;
            SceneManager.LoadScene(1);
        }
    }
}