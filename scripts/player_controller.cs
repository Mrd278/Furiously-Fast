using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour {

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Fixedupdate()
    {
        float movehorizontal = Input.GetAxis("Horizontal");
        float movevertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(movehorizontal, 0.0f, movevertical);
        rb.AddForce(movement *100);
    }
	
}
