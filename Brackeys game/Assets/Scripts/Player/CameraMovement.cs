
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player; //get the transform of something
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset; //small cap is the transform attached to the object
    }
}
