using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{ 
    // Update is called once per frame
    public Vector3 CenterOfMass2;
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.centerOfMass = CenterOfMass2;
        if (Input.GetKey(KeyCode.W))
            rb.AddRelativeForce(Vector3.up * 15f);
        if (Input.GetKey(KeyCode.A)) 
            rb.AddTorque(0.25f);
        if (Input.GetKey(KeyCode.D))  
            rb.AddTorque(-0.25f);
    } 
}
