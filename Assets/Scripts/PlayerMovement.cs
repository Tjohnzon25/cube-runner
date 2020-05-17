using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // We marked this as "Fixed"Update because we are using it to mess with physics
    void FixedUpdate(){

        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Time.deltaTime make the framerate the same for all computers

        if (Input.GetKey("d")) //when user presses the key "D"
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) //when user presses the key "A"
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
