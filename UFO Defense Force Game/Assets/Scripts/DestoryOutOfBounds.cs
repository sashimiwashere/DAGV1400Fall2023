using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour
{
    public float topBounds = 50;
    public float lowerBounds = -50;

    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds)
        {
            print("Item has be destroied");
            Destroy(gameObject);
        }
    }
}
