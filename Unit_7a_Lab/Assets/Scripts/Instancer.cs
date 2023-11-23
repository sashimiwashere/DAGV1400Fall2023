using System;
using System.Security.Principal;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu]

public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num;
    
    public void CreateInstance ()
    {
        Instantiate(prefab);
    }

    public void CreateInstance (Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }

    public void CreateInstanceFromList (Vector3DataList obj)
    {
        foreach (Vector3Data v in obj.vector3list)
        {
            Instantiate(prefab, v.value, Quaternion.identity);
        }
    }

    public void CreateInstanceFromListCounting (Vector3DataList obj)
    {
        Instantiate(prefab, obj.vector3list[num].value, Quaternion.identity);
        num++;

        if (num == obj.vector3list.Count)
        {
            num = 0;
        }
    }

        public void CreateInstanceListRandomly (Vector3DataList obj)
    {
        num = Random.Range(0, obj.vector3list.Count -1);
        Instantiate(prefab, obj.vector3list[num].value, Quaternion.identity);

    }
    

}
