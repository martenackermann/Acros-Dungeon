using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float thurst;
    [SerializeField] float roation;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }


    void ProcessInput()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.up * thurst * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            ApplyRotation(roation);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-roation);
        }


    }

    private void ApplyRotation(float roationThisFrame)
    {
        rb.freezeRotation = true; //Freeze Rotation so Player can Rotate
        transform.Rotate(Vector3.forward * roationThisFrame * Time.deltaTime);
        rb.freezeRotation = false; // Unfreez 
    }
}
