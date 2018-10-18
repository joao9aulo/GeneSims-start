using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplicarMover : MonoBehaviour
{

    public Rigidbody rb;

    public GameObject cubo;

    public float force = 500f;

    public static int count = 0;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Reproduzir", 5.0f, 5.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody rb = cubo.GetComponent<Rigidbody>();

        int direcao = Random.Range(1, 5);

        if (direcao == 1)
        {
            rb.AddForce(0, 0, force * Time.deltaTime);
        }

        if (direcao == 2)
        {
            rb.AddForce(force * Time.deltaTime, 0, 0);
        }

        if (direcao == 3)
        {
            rb.AddForce(0, 0, -force * Time.deltaTime);
        }

        if (direcao == 4)
        {
            rb.AddForce(-force * Time.deltaTime, 0, 0);
        }
    }

    void Reproduzir()
    {
        count++;
        if (count < 2500)
        {
            Instantiate(cubo, new Vector3(rb.position.x + 1, rb.position.y, rb.position.z), Quaternion.identity);
        }

    }
}