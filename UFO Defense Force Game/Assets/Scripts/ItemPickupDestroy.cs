using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickupDestroy : MonoBehaviour
{
    private float lowerBounds = -30f;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            print("Item collected");
        }
    }

    void Update()
    {
        if(transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
            print("Item destroied");
        }
    }
}
