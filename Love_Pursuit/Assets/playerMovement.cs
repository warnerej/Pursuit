using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //the player object
    //movement speed
    //jump
    //walk/run
    //crouch for funsies

    public float mvmtSpeed = 0;

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
        }
        //myRigidBody.velocity = Vector(something something) * mvmtSpeed
    }
}
