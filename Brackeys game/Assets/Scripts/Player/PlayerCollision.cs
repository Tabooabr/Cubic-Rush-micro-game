
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        //using collision info to access the collider that hit and getting its name.

        if (collisionInfo.collider.tag == "Obstacle") //here using obstacle keyword works if the tag of the object contains obstacle but can have something else too.
        {
            Debug.Log("you hit:" + collisionInfo.collider.tag);
            GetComponent<PlayerMovement>().enabled = false; //disable player movement
            FindObjectOfType<GameManager>().EndGame();
           
        }
    }
}
