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
    }
    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
            SceneManager.LoadScene("scene2");
    }
}
