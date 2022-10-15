using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    //This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float upwardsForce = 20;

    //We marked this as "Fixed"Update because we are using it to mess around with physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, upwardsForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1.00f)
        {
            FindObjectOfType<Game_Manager>().game_over();
        }
    }
}
