using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedObjectDestructor : MonoBehaviour
{
    public float deadspace = -5f;
    void Update()
    {
        if(transform.position.x < deadspace)
        {
            Object.Destroy(gameObject);
        }
    }
}
