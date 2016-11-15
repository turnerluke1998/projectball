using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            lives.livesCount = 0;
            lives.deathCount++;
            PlayerPrefs.SetInt("Deaths", lives.deathCount);
            Coin.coinCount = PlayerPrefs.GetInt("Score");
            PlayerPrefs.SetInt("Deaths", lives.deathCount);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
            Coin.coinCount = 0;
            lives.livesCount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}