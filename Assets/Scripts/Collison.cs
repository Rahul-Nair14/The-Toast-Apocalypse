using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collison : MonoBehaviour
{
    public int damage = 1;
    public int enemyspeed = 10;
    public GameObject Effect;
    private ShakeCam Vibrate;
    public AudioClip Clip;
    public AudioSource CrunchySource;
    
    
    public void Start()
    {
        Vibrate = GameObject.FindGameObjectWithTag("ScreenShaker").GetComponent<ShakeCam>();
        
        
    }
    public void Update()
    {
        transform.Translate(Vector2.left * enemyspeed * Time.deltaTime);
        
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {

            
            other.GetComponent<BreadMovement>().health -= damage;
            Debug.Log("IDK");
            CrunchySource.PlayOneShot(Clip);
            Debug.Log("Audio works");
            Instantiate(Effect, transform.position, Quaternion.identity);
            Vibrate.ShakeCamera();
            Destroy(gameObject);
        }
    }
}
