using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate() // Use FixedUpdate when calculating physics. See: https://stackoverflow.com/questions/34447682/what-is-the-difference-between-update-fixedupdate-in-unity 
    {
        // Adding a forward force on Z-axis
        this.rb.AddForce(0, 0, this.forwardForce * Time.deltaTime); // '* Time.deltaTime' is used to make it frame rate invariant.

        if (Input.GetKey("d"))
        {
            this.rb.AddForce(this.sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // VelocityChange ignores the mass and makes the movement instantaneous
        }
        if (Input.GetKey("a"))
        {
            this.rb.AddForce(-this.sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
