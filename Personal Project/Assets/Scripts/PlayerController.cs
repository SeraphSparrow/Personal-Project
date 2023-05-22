using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float turnSpeed = 100.0f;    
    private float horizontalInput;
    private float forwardInput;
    public float xRange = 240;
    public float zRange = 205;
    public float mvtForce;
    public float maxVelSqr;
    
    public Rigidbody playerRb;

    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //move forward
        if(playerRb.velocity.sqrMagnitude < maxVelSqr)
        {
            playerRb.AddRelativeForce(Vector3.forward * Time.deltaTime * forwardInput * mvtForce);
        }

        //turn around 
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        /*
        if (transform.position.x < -xRange)
            {transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);}
        if (transform.position.x > xRange)
            {transform.position = new Vector3(xRange, transform.position.y, transform.position.z);}
        if (transform.position.z < -zRange)
            {transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);}
        if (transform.position.z > zRange)
            {transform.position = new Vector3(transform.position.x, transform.position.y, zRange);}
        */
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            Destroy(other.gameObject);
            FindObjectOfType<SpawnManager>().SpawnRandomFood();
        }
    }

}
