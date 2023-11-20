using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleControl : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 18.0f;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        input = input.normalized;
        rb.AddForce(input*speed);
    }
}
