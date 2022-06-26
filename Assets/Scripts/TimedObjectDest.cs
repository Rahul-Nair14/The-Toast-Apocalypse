using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedObjectDest : MonoBehaviour
{

    public float destTime = 5.0f;
    void Update()
    {
        Object.Destroy(gameObject, destTime);
    }
}
