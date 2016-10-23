using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour
{

    public float moveSpeed;
    public float jump;
    float moveVelocity;
    bool grounded = false;
    private object objectCollider;

    // Use this for initialization
    void Start()
    {
        moveSpeed = 7;

    }

    // Update is called once per frame
    void Update()
    {
        //Jump control
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            if (grounded) {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
            }
        }
        moveVelocity = 0;
        if (Input.GetKey(KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
            moveVelocity = -moveSpeed; //move it left
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            moveVelocity = moveSpeed; //move it right
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D> ().velocity.y);
    }
    //checks if it is on the ground or not
    void OnTriggerEnter2D() {
        grounded = true;
    }
    void OnTriggerExit2D() {
        grounded = false;
    }
}