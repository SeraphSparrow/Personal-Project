using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] foodPrefabs;
    private float spawnRangeX = 95;
    private float spawnRangeZ = 65;
    // private float startDelay = 2; // 4.4
    // private float spawnInterval = 1.5f; // 4.4

    void Start()
    {
        // InvokeRepeating("SpawnRandomFood", startDelay, spawnInterval);
        // SpawnFoodWave(); // 4.4
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

    /*
    void SpawnFoodWave() // this shit in 4.4 allegedly 
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(foodPrefabs, SpawnRandomFood());
        }
    }
    */
}
