using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(RigidbodyType2D))]
public class Collectable : MonoBehaviour
{
    public static Action collected;

    [Range(0, 100)]
    [SerializeField] float speed;

    [SerializeField] float org, max, floatDist = 0.2f;
    const float floatMult = 0.02f;
    int dir = -1;

    private void Awake() {
        org = transform.position.y;
        max = transform.position.y + floatDist;
    }

    private void Update() {
        transform.rotation = Quaternion.Euler(
            transform.rotation.eulerAngles.x, 
            transform.rotation.eulerAngles.y + speed * Time.deltaTime, 
            transform.rotation.eulerAngles.z
        );

        if (transform.position.y <= org) {
            dir = -dir;
            transform.position = new Vector3(transform.position.x, org, transform.position.z);
        }
        if (transform.position.y >= max) {
            dir = -dir;
            transform.position = new Vector3(transform.position.x, max, transform.position.z);
        }
        transform.position = new Vector3(transform.position.x, transform.position.y + (dir * speed * floatMult * Time.deltaTime), transform.position.z);
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") collected?.Invoke();
        GameObject.Destroy(gameObject);
    }
}
