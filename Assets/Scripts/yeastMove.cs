using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yeastMove : MonoBehaviour
{
    public int pickup = 5;
    public int yeastspeed = 10;
    public GameObject Effect;
    public AudioClip Clip;
    public AudioSource CrunchySource;

    public void Start()
    {
        CrunchySource = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();
    }
    public void Update()
    {
        transform.Translate(Vector2.left * yeastspeed * Time.deltaTime);


    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<BreadMovement>().health += pickup;
           // CrunchySource.PlayOneShot(Clip);
            Instantiate(Effect, transform.position, Quaternion.identity);
            Object.Destroy(gameObject);
        }
    }
}