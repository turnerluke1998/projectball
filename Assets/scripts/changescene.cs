using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();

        Debug.Log("Active scene is '" + scene.name + "'.");
    }

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
            Coin.totalcoinCount++;
            PlayerPrefs.SetInt("TotalCoins", Coin.totalcoinCount);
        }
        if (Input.GetKey("-"))
        {
            Coin.coinCount--;
            Coin.totalcoinCount--;
        }
        if (Input.GetKey("]"))
        {
            lives.livesCount++;
        }
        if (Input.GetKey("["))
        {
            lives.livesCount--;
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("TotalCoins", Coin.totalcoinCount);
            PlayerPrefs.SetInt("Coins", Coin.coinCount);
            PlayerPrefs.SetInt("Cables", Cable.cableCount);
            PlayerPrefs.SetInt("Gems", Gem.gemCount);
            PlayerPrefs.SetInt("Lives", lives.livesCount);
            if (SceneManager.GetActiveScene().name == "scene1")
            {
                levelselector.isLocked = 1;
                PlayerPrefs.SetInt("isLocked", levelselector.isLocked); 
                SceneManager.LoadScene("scene1_victory");
            }
            if (SceneManager.GetActiveScene().name == "scene2")
            {
                SceneManager.LoadScene("scene2_victory");
            }
        }
    }
}
