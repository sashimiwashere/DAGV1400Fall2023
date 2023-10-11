using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDropDown : MonoBehaviour
{
    public float dropSpeed = 20;

    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * dropSpeed);  // drop down the item
    }
}