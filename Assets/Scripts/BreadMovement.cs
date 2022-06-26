using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class BreadMovement : MonoBehaviour
{
    private Vector2 Targetpos;
    public float MaxHeight;
    public float MinHeight;
    public float Yincrement;
    public float speed;
    

    public GameObject UIGamePaused;

    public int health = 5;
    public float time;
    public float Timesave;
    
    public GameObject Crunchy;
    Animator CrunchAnim;
    


    public Text HealthDisplay;
    public Text ScoreText;
    public GameObject Effect;


    public AudioClip GameOver;
    public AudioClip Movement;
    AudioSource SoundDesign;

    Boolean Audionotplayed = true;
    

    public void Start()
    {
        
        CrunchAnim = Crunchy.GetComponent<Animator>();
        SoundDesign = this.GetComponent<AudioSource>();
        CrunchAnim.SetBool("Dead", false);
        ScoreText.text = "0";
        
        
    }
    public void Update()
    {
        
        HealthDisplay.text = health.ToString();
        ScoreText.text = time.ToString("F2");
        PlayerPrefs.SetFloat("Score", time);

        if(health <= 0 && Audionotplayed)
        {
            CrunchAnim.SetBool("Dead", true);
            HealthDisplay.text = "0";
            Invoke("Loading", 1.5f);
            
            SoundDesign.PlayOneShot(GameOver);
            Audionotplayed = false;
            
        }
        if (transform.position.y == 0 || transform.position.y < MaxHeight || transform.position.y > MinHeight)
        {
            transform.position = Vector2.MoveTowards(transform.position, Targetpos, speed * Time.deltaTime);
            
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < MaxHeight)
        {
           
            Targetpos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            Instantiate(Effect, transform.position, Quaternion.identity);
            SoundDesign.PlayOneShot(Movement);

            

        }
        else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > MinHeight)
        {
           
            Targetpos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            Instantiate(Effect, transform.position, Quaternion.identity);
            SoundDesign.PlayOneShot(Movement);

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale > 0f)
            {
                UIGamePaused.SetActive(true); // this brings up the pause UI
                Time.timeScale = 0f; // this pauses the game action
               
            }
            else
            {
                Time.timeScale = 1f; // this unpauses the game action (ie. back to normal)
                UIGamePaused.SetActive(false); // remove the pause UI
               
            }

        }
        if(Time.timeScale == 0)
        {
            time = time + 0;
        }
        else
        {
            time = time + 0.1f;
        }
        

    }
    void Loading()
    {
        SceneManager.LoadScene(3);
    }


}
