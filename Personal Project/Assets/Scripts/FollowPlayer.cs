using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Camera 
    public GameObject player;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = player.transform.position + new Vector3(0,10,0);
    }
}
