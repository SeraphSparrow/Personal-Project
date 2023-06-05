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
    
    public GameManager gameManager;
    public Rigidbody playerRb;
    private AudioSource playerAudio;
    public AudioClip collectSound;
    public ParticleSystem explosionParticle;

    void Start()
    {
       gameManager = FindObjectOfType<GameManager>();
       playerAudio = GetComponent<AudioSource>();
    }

// Movement
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //move forward
        if(playerRb.velocity.sqrMagnitude < maxVelSqr && gameManager.isGameActive)
        {
            playerRb.AddRelativeForce(Vector3.forward * Time.deltaTime * forwardInput * mvtForce);
        }

        //turn around 
        if(gameManager.isGameActive)
        {
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        }
    }

// Collide with food + Destroy + Sparkly 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            Destroy(other.gameObject);
            Instantiate(explosionParticle, other.transform.position, explosionParticle.transform.rotation);
            FindObjectOfType<SpawnManager>().SpawnRandomFood();
            gameManager.UpdateScore(5);
            playerAudio.PlayOneShot(collectSound, 1.0f);
        }
    }

}
