using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //the player object
    public Transform groundedCheck;
    public float groundednessRadius;
    public LayerMask groundLayer;
    public BoxCollider2D elCollider;
    public Rigidbody2D elRigidBody;
    //movement speed
    public float horizSpeed = 0.75f;
    //jump
    public float jumpPower = 4f;
    public float maxSpeed = 2f;
    private float xMove;
    //walk/run
    //crouch for funsies


    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Creates a cute little circle of death at the character's feet; tells us if it's colliding with the ground or not!
    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundedCheck.position, groundednessRadius, groundLayer);
    }

    // Update is called once per frame
    void Update()
    {
        //get horizontal
        if (Input.GetKey(KeyCode.A))
        {
            xMove = -1;
            
        } else if (Input.GetKey(KeyCode.D))
        {
            xMove = 1;
        }  else
        {
            xMove = 0;
            elRigidBody.velocity = new Vector2 (0, elRigidBody.velocity.y);
        }

        //jump
        if((Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.Space)) && isGrounded())
        {
            elRigidBody.velocity += Vector2.up * jumpPower;

        }
    }

    private void FixedUpdate()
    {
        elRigidBody.velocity = new Vector2(elRigidBody.velocity.x + xMove * horizSpeed, elRigidBody.velocity.y);

        if (elRigidBody.velocity.x >= maxSpeed * horizSpeed) 
        { 
            elRigidBody.velocity = new Vector2(elRigidBody.velocity.x, elRigidBody.velocity.y);
        } else
        {
            elRigidBody.velocity = new Vector2(elRigidBody.velocity.x + xMove * horizSpeed, elRigidBody.velocity.y);
        }
    }
}
