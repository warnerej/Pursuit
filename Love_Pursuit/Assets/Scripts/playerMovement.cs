using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //the player object
    public BoxCollider2D elCollider;
    public Rigidbody2D elRigidBody;
    //movement speed
    public float mvmtSpeed = 2;
    //jump
    public float jumpPower = 2;
    //walk/run
    //crouch for funsies


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //jump! Add something to the velocity, toggle this button to be off so that they won't be flying into the void if they hold space down
            elRigidBody.velocity += Vector2.up * jumpPower;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            elRigidBody.velocity += Vector2.left * mvmtSpeed;
        }
        if(Input.GetKeyDown(KeyCode.D))
        { 
            elRigidBody.velocity += Vector2.right * mvmtSpeed; 
        }
        if ((Input.GetKeyDown(KeyCode.W)))
        {
            elRigidBody.velocity += Vector2.up;
        }

        if ((Input.GetKeyDown (KeyCode.S)))
        {
            //will someday be a crouch
        }
    }
}
