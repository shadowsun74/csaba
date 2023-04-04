using System.Collections.Generic;
using UnityEngine;

class GravityModifier : MonoBehaviour
{
    List<Rigidbody> rigidbodies = new List<Rigidbody>();
    [SerializeField] Vector3 gravity;

    void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
            rigidbodies.Add(rb);
    }

    void OnTriggerExit(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
            rigidbodies.Remove(rb);
    }

    void FixedUpdate()
    {
        foreach (Rigidbody rb in rigidbodies)
        {
            rb.velocity += gravity * Time.fixedDeltaTime; 
        }
    }
}

