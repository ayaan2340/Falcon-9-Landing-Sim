using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{ 
    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector3 vertical = new Vector3(-0.4f*(rb.rotation), 0f, 0f);
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(vertical);
        if (Input.GetKey(KeyCode.A)) 
            rb.MoveRotation(rb.rotation + 0.5f);
        if (Input.GetKey(KeyCode.D))  
            rb.MoveRotation(rb.rotation + -0.5f);
        if(Input.GetKey(KeyCode.S))
            rb.AddForce(-vertical);
    } 
}
