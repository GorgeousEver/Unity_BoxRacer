using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce;// Can not push the object if this value is too small
    public float sideawayForce;

    private bool isLeft = false;
    private bool isRight = false;

    // Update is called once per frame
    void Update()
    {
        isLeft = Input.GetKey("a");
        isRight = Input.GetKey("d");
    }

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (isLeft)
        {
            rb.AddForce(-sideawayForce * Time.deltaTime, 0, 0);
        }

        if (isRight)
        {
            rb.AddForce(sideawayForce * Time.deltaTime, 0, 0);
        }
    }
}
