using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Speed multipier for Horizontal and Vertical movement")]
    public float speed = 10;

    // get a reference to a rigidbody.
    Rigidbody rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // create a function to move.
    public void MoveHorizontal(float force)
    {
        rb.AddForce(force * speed, 0, 0);
    }

    // create a function to move.
    public void MoveVertical(float force)
    {
        rb.AddForce(0, 0, force * speed);
    }
}
