using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemDropSystem : MonoBehaviour
{
    public GameObject[] itemPrefabs;
    private float spawnRangeX = 40f;
    private float spawnPosZ = 30f;
    private float startDelay = 0;
    private float spawnInterval = 3f;
    
    void Start() 
    {
        InvokeRepeating("SpawnRandomItem", startDelay, spawnInterval);
    }

    void SpawnRandomItem() 
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX), 0,spawnPosZ);
        
        int itemIndex = Random.Range(0,itemPrefabs.Length);
        
        Instantiate(itemPrefabs[itemIndex],spawnPos,itemPrefabs[itemIndex].transform.rotation);
    }
}