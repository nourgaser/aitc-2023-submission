using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Range(1, 10)]
    [SerializeField] float speed = 5;
    float mult = 500;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A)) rb.AddForce(-speed * mult * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.D)) rb.AddForce(speed * mult * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.W)) rb.AddForce(0, 0, speed * mult * Time.deltaTime);
        if (Input.GetKey(KeyCode.S)) rb.AddForce(0, 0, -speed * mult * Time.deltaTime);
    }
}
