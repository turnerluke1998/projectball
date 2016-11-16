using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelnamescript : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKey)
            Destroy(this.gameObject);
    }
}