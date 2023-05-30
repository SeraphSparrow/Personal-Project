using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] foodPrefabs;
    private float spawnRangeX = 95;
    private float spawnRangeZ = 65;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SpawnRandomFood()
    {
        int foodIndex = Random.Range(0, foodPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate (foodPrefabs[foodIndex], spawnPos, foodPrefabs[foodIndex].transform.rotation);
    }
}
