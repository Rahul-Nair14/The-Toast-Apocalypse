using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{

    public float platformspeed;
    public GameObject NewPlatform;
    public Vector3 originalpos;
   
    public void Update()
    {
        transform.Translate(Vector2.left * platformspeed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "NewPlatform")
        {
            
            Instantiate(NewPlatform, originalpos, Quaternion.identity);
            
        }
    }

}
