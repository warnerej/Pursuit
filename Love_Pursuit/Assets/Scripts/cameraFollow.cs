
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    // Tells the code that the player is the desired target to follow
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset; // Values to offset the camera from the player by

    // Keeps the camera from competing for updates with the player
    private void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // Makes the position of the camera 
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Lets the camera have a mix of where we are and where we want to be when following
        transform.position = smoothedPosition;
    }


}
