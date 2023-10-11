using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; // Array to store UFO ships
    private float spawnRangeX = 40f;
    private float spawnPosZ = 30f;
    private float startDelay = 3f;
    private float spawnInterval = 5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }

    void SpawnRandomUFO()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX), 0,spawnPosZ);
        
        int ufoIndex = Random.Range(0,ufoPrefabs.Length);   // pick a random ufo from array
        
        Instantiate(ufoPrefabs[ufoIndex],spawnPos,ufoPrefabs[ufoIndex].transform.rotation); // spawn a ufo from the ufoIndex at random location on X axis
    }
}
