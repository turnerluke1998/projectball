using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
            Coin.coinCount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}