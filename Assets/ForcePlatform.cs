using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcePlatform : MonoBehaviour
{
    public float force = 20f;
    public bool zeroOutVelocity = true;
    public bool singleUse = false;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if(zeroOutVelocity) rb.velocity = Vector3.zero;
            rb.AddForce(this.transform.up * force, ForceMode.Impulse);
            if(singleUse) Destroy(this.gameObject);
        }
    }
}
