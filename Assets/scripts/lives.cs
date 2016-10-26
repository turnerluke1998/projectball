using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class lives : MonoBehaviour
{
    public static int livesCount = 0;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;


    // Use this for initialization
    void Start()
    {
    }

    void Update()
    {
    }

    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            livesCount++;
            Destroy(gameObject);
        }
        if (livesCount == 1)
        {
            Destroy(Heart1);
        }
        if (livesCount == 2)
        {
            Destroy(Heart3);
        }
        if (livesCount == 3)
        {
            Destroy(Heart2);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            livesCount = 0;
            Coin.coinCount = 0;
        }
    }
}

        /*
                if (livesCount == 2)
                livesCount = livesCount - 1;
            Destroy(Heart2);
            Destroy(gameObject);
            if (livesCount == 1)
                livesCount = livesCount - 1;
            Destroy(Heart3);
            Destroy(gameObject);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        */
//if (lives == 2) display "heart" at(some coordinates) display "heart" at(some coordinates);
//if (lives == 3) display "heart" at(some coordinates) display "heart" at(some coordinates) display "heart" at(some coordinates)