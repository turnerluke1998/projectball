using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    public bool enablecheats;

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
            if (Input.GetKeyDown(KeyCode.Numlock))
        {
            enablecheats = true;
            Debug.Log("Cheats enabled.");
        }
        if (enablecheats == true)
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                SceneManager.LoadScene(1);
            }
            if (Input.GetKeyDown(KeyCode.F2))
            {
                SceneManager.LoadScene(2);
            }
            if (Input.GetKeyDown(KeyCode.F3))
            {
                SceneManager.LoadScene(3);
            }
            if (Input.GetKeyDown(KeyCode.F4))
            {
                SceneManager.LoadScene(4);
            }
            if (Input.GetKeyDown(KeyCode.F5))
            {
                SceneManager.LoadScene(5);
            }
            if (Input.GetKeyDown(KeyCode.F6))
            {
                SceneManager.LoadScene(6);
            }
            if (Input.GetKeyDown(KeyCode.F7))
            {
                SceneManager.LoadScene(7);
            }
            if (Input.GetKeyDown(KeyCode.F8))
            {
                SceneManager.LoadScene(8);
            }
            if (Input.GetKeyDown(KeyCode.F9))
            {
                SceneManager.LoadScene(9);
            }
            if (Input.GetKeyDown(KeyCode.F10))
            {
                SceneManager.LoadScene(10);
            }
            if (Input.GetKeyDown(KeyCode.F11))
            {
                SceneManager.LoadScene(11);
            }
            if (Input.GetKeyDown(KeyCode.F12))
            {
                SceneManager.LoadScene(12);
            }
            if (Input.GetKeyDown(KeyCode.Equals))
            {
                Coin.coinCount++;
                Coin.totalcoinCount++;
                PlayerPrefs.SetInt("TotalCoins", Coin.totalcoinCount);
            }
            if (Input.GetKeyDown(KeyCode.Minus))
            {
                Coin.coinCount--;
                Coin.totalcoinCount--;
            }
            if (Input.GetKeyDown(KeyCode.LeftBracket))
            {
                lives.livesCount++;
            }
            if (Input.GetKeyDown(KeyCode.RightBracket))
                {
                lives.livesCount--;
            }
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
            levelselector.isComplete_1 = PlayerPrefs.GetInt("level1_iscomplete");
            levelselector.isComplete_2 = PlayerPrefs.GetInt("level2_iscomplete");
            levelselector.isComplete_3 = PlayerPrefs.GetInt("level3_iscomplete");
            levelselector.isComplete_4 = PlayerPrefs.GetInt("level4_iscomplete");
            if (SceneManager.GetActiveScene().name == "scene1")
            {
                levelselector.isLocked = PlayerPrefs.GetInt("isLocked");
                if (levelselector.isLocked <= 0)
                {
                    levelselector.isLocked = 1;
                }
                PlayerPrefs.SetInt("isLocked", levelselector.isLocked); 
                SceneManager.LoadScene("scene1_victory");
                return;
            }
            if (SceneManager.GetActiveScene().name == "scene2")
            {
                if (levelselector.isLocked <= 1)
                {
                    levelselector.isLocked = 2;
                }
                PlayerPrefs.SetInt("isLocked", levelselector.isLocked);
                SceneManager.LoadScene("scene2_victory");
                return;
            }
            if (SceneManager.GetActiveScene().name == "scene3")
            {
                if (levelselector.isLocked <= 2)
                {
                    levelselector.isLocked = 3;
                }
                PlayerPrefs.SetInt("isLocked", levelselector.isLocked);
                SceneManager.LoadScene("scene3_victory");
                return;
            }
            if (SceneManager.GetActiveScene().name == "scene4")
            {
                if (levelselector.isLocked <= 3)
                {
                    levelselector.isLocked = 4;
                }
                PlayerPrefs.SetInt("isLocked", levelselector.isLocked);
                SceneManager.LoadScene("scene4_victory");
                return;
            }
        }
    }
}
