using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;

public class Movement : MonoBehaviour
{
    
    private Rigidbody rb;
    public float moveForce;

    private Vector3 rotation;
  
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        float turnAngle = Mathf.Abs(180 - transform.eulerAngles.y);
        if (Input.GetKeyDown("left"))
        {
            TurnLeft();
        }

        if (Input.GetKeyDown("right"))
        {
            TurnRight();
        }
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.AddForce(Vector3.right * horizontalInput * moveForce);
    }

    void TurnLeft()
    {
        if (transform.eulerAngles.y < 269)
        {
            transform.Rotate(new Vector3(0, moveForce, 0) * Time.deltaTime);
        }
    }
    
    void TurnRight()
    {
        if (transform.eulerAngles.y < 96)
        {
            transform.Rotate(new Vector3(0, moveForce, 0) * Time.deltaTime);
        }
    }
}
