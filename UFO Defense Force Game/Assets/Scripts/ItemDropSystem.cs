using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDropSystem : MonoBehaviour
{
    public float countDown = 5f;
    public float newCountDown = 5f;
    private float dropTime = 0f;
    public Transform dropper;
    public Transform item;

    void Start()
    {
        
    }

    void Update()
    {
        countDown -= 1f * Time.deltaTime;
        if(countDown <= dropTime)
        {
            Instantiate(item, dropper.transform.position, item.transform.rotation);
            countDown = newCountDown;
        }
    }
}
