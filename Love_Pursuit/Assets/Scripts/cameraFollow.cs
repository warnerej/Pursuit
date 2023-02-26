
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    // Tells the code that the player is the desired target to follow
    public Transform target;

    public float smoothSpeed = 0.5f;
    public Vector3 offset; // Values to offset the camera from the player by

    // Keeps the camera from competing for updates with the player
    private void LateUpdate()
    {
        transform.position = target.position + offset;
    }


}
