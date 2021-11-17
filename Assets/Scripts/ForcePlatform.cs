using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcePlatform : MonoBehaviour
{
    public float force = 20f;
    public bool zeroOutVelocity = true;
    public bool singleUse = false;

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Vector3 direction = transform.TransformDirection(Vector3.up) * force * .5f;
        Gizmos.DrawRay(transform.position, direction);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            rb.gameObject.transform.position = this.transform.position;
            if(zeroOutVelocity) rb.velocity = Vector3.zero;
            rb.AddForce(this.transform.up * force, ForceMode.Impulse);
            if(singleUse) Destroy(this.gameObject);
        }
    }
}
