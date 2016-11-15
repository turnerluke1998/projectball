using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    //Use this for initialization
    public void changeToScene(int changeTheScene)
    {
        SceneManager.LoadScene(changeTheScene);
    }
    public void Update()
    {
        if (Input.GetKey("0"))
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKey("2"))
        {
            SceneManager.LoadScene(2);
        }
        if (Input.GetKey("3"))
        {
            SceneManager.LoadScene(3);
        }
        if (Input.GetKey("4"))
        {
            SceneManager.LoadScene(4);
        }
        if (Input.GetKey("5"))
        {
            SceneManager.LoadScene(5);
        }
        if (Input.GetKey("="))
        {
            Coin.coinCount++;
        }
        if (Input.GetKey("-"))
        {
            Coin.coinCount--;
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("Score", Coin.coinCount);
            PlayerPrefs.SetInt("Cables", Cable.cableCount);
            PlayerPrefs.SetInt("Gems", Gem.gemCount);
            SceneManager.LoadScene("scene2");
            Coin.coinCount = PlayerPrefs.GetInt("Score");
            Coin.highscorecoinCount = PlayerPrefs.GetInt("Score");
            Cable.cableCount = PlayerPrefs.GetInt("Cables");
            Gem.gemCount = PlayerPrefs.GetInt("Gems");
        }
    }
    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
            SceneManager.LoadScene("scene2");
    }
}
