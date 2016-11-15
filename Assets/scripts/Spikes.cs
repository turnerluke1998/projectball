using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Spikes : MonoBehaviour
{
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public GameObject damage;


    // Use this for initialization
    void Start()
    {

    }

    /*void OnCollisionEnter2D(Collision2D coll)
    //destroys a heart each time you touch an enemy and then if all 3 hearts are gone, you die.
    {
        if (coll.gameObject.tag == "Player")
        {
        }
        if (lives.livesCount == 0)
        {
            Destroy(Heart1);
            lives.livesCount++;
            //damage.SetActive(true);
            return;
            //damage.SetActive(false);
        }
        if (lives.livesCount == 1)
        {
            Destroy(Heart2);
            lives.livesCount++;
            damage.SetActive(true);
            return;
            //damage.SetActive(false);
        }
        if (lives.livesCount == 2)
        {
            Destroy(Heart3);
            lives.deathCount++;
            PlayerPrefs.SetInt("Deaths", lives.deathCount);
            lives.livesCount = 0;
            Coin.coinCount = 0;
            //damage.SetActive(true);
            //damage.SetActive(false);
            Coin.coinCount = PlayerPrefs.GetInt("Score");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }*/
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