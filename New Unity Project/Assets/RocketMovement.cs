using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.up * Time.deltaTime * 10f;
        if (Input.GetKey(KeyCode.A)) 
            rb.MoveRotation(rb.rotation + 0.25f * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))  
            rb.MoveRotation(rb.rotation + -0.25f * Time.deltaTime);
    }       
}
