using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Speed multipier for Horizontal and Vertical movement")]
    [Range(5f,50f)]
    public float speed = 10, jumpForce = 5;

    public int coinValue = 1;

    public Vector3 dir;
    public Vector3 startPosition;

    public bool isGrounded = true;
    public bool canJump = false;

    private Rigidbody rb;
    private int coins = 0;

    // void Awake()
    // {
    //     DontDestroyOnLoad(this.gameObject);
    // }

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        startPosition = GameObject.Find("Start Here").transform.position;
        if(PlayerPrefs.GetInt("canJump") == 1)
        {
            Debug.Log("We can jump")
            canJump = true;
        }
        ResetPlayer();
    }

    void FixedUpdate()
    {
        rb.AddForce(dir * speed);

        if(this.transform.position.y < -20)
        {
            ResetPlayer();
        }
    }

    public void ResetPlayer()
    {
        this.transform.position = startPosition;        // move player
        rb.velocity = Vector3.zero;                     // set speed to zero
        rb.angularVelocity = Vector3.zero;              // set rotation to zero
        this.transform.rotation = Quaternion.identity;  // set rotation to 0,0,0

        // canJump = false;
    }

    public void Jump()
    {
        if(isGrounded && canJump) 
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Floor"))
        {
            isGrounded = true;
        }

        else if(other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            ScoreManager.instance.ChangeScore(coinValue);
        }

        else if(other.gameObject.CompareTag("JumpPowerUp"))
        {
            canJump = true;
            PlayerPrefs.SetInt("canJump", 1);   // 1 is true, 0 is false.
            Destroy(other.gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Floor"))
        {
            isGrounded = false;
        }
    }

    // create a function to move.
    // public void MoveHorizontal(float force)
    // {
    //     rb.AddForce(force * speed, 0, 0);
    // }

    // // create a function to move.
    // public void MoveVertical(float force)
    // {
    //     rb.AddForce(0, 0, force * speed);
    // }
}
