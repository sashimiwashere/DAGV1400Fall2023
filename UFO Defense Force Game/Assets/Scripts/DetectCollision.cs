using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{ 
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else if(other.gameObject.CompareTag("Weapon"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}