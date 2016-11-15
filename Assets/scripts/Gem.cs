using UnityEngine;
using System.Collections;

public class Gem : MonoBehaviour
{
    public static int gemCount = 0;


    /*id OnGUI()
    {
        string coinText = "" + coinCount;
        GUI.skin.box.fontSize = 100;
        GUI.Box(new Rect(Screen.width - 1650, 90, 160, 130), coinText);
    }*/

    // Use this for initialization
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Animator animator = GetComponent<Animator>();

            AnimatorOverrideController overrideController = new AnimatorOverrideController();

            animator.runtimeAnimatorController = overrideController;
            Destroy(gameObject);
            if (gemCount <= 4)
            {
                gemCount++;
            }
        }
    }
}