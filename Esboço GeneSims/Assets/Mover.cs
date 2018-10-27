using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public Rigidbody rb;
    public float force;

    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, -force * Time.deltaTime);
    }
}
