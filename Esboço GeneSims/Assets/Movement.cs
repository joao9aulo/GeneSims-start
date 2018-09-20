using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Rigidbody rb;

    public float force = 500f;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        Random rnd = new Random();

        int direcao = Random.Range(1, 5);

        if(direcao == 1)
        {
            Debug.Log("1");
            rb.AddForce(0, 0, force * Time.deltaTime);
        }

        if (direcao == 2)
        {
            Debug.Log("2");
            rb.AddForce(force * Time.deltaTime, 0, 0);
        }

        if (direcao == 3)
        {
            Debug.Log("3");
            rb.AddForce(0, 0, -force * Time.deltaTime);
        }

        if (direcao == 4)
        {
            Debug.Log("4");
            rb.AddForce(-force * Time.deltaTime, 0, 0);
        }
    }
}
