using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerRB;

    public float pushz = 2000;
    public float sidewaysForce = 500; 
   

    // Update is called once per frame
    void FixedUpdate()      // for physics and stuff like that use FIXEDUPDATE as unity likes it a lot more
    {
        //adding forward force.
        playerRB.AddForce(0, 0, pushz * Time.deltaTime); //multiplying by the ammount of seconds since the computer drew last frames, so the higher frame rate the lower the value. so it equializes framerate.


        if (Input.GetKey("d"))
        {
                //
                playerRB.AddForce(sidewaysForce * Time.deltaTime , 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
                //
                playerRB.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (playerRB.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }

}
