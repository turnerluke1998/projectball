using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using System.Threading;

public class lives : MonoBehaviour
{
    public static int livesCount;
    public static int enemyCount;
    public static int deathCount;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public GameObject damage;



    // Use this for initialization
    void Start()
    {
        damage.SetActive(false);
        livesCount = 0;
    }

    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D coll)
        //destroys a heart each time you touch an enemy and then if all 3 hearts are gone, you die.
    {
        if (coll.gameObject.tag == "Player")
        {
        }
        if (livesCount == 0)
        {
            Destroy(Heart1);
            livesCount++;
            enemyCount++;
            PlayerPrefs.SetInt("Enemies", lives.enemyCount);
            Destroy(gameObject);
            //damage.SetActive(true);
            return;
            //damage.SetActive(false);
        }
        if (livesCount == 1)
        {
            Destroy(Heart2);
            livesCount++;
            enemyCount++;
            PlayerPrefs.SetInt("Enemies", lives.enemyCount);
            Destroy(gameObject);
            damage.SetActive(true);
            return;
            //damage.SetActive(false);
        }
        if (livesCount == 2)
        {
            Destroy(Heart3);
            lives.deathCount++;
            PlayerPrefs.SetInt("Deaths", lives.deathCount);
            livesCount = 0;
            enemyCount++;
            PlayerPrefs.SetInt("Enemies", lives.enemyCount);
            Coin.coinCount = 0;
            Destroy(gameObject);
            //damage.SetActive(true);
            //damage.SetActive(false);
            Coin.coinCount = PlayerPrefs.GetInt("Score");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
