using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow2d : MonoBehaviour
{

    public float xoffset;
    public float yoffset;
    public float zoffset = -10f;
    public GameObject Player;

    public void Update()
    {
        transform.position = new Vector3(Player.GetComponent<Transform>().position.x + xoffset, Player.GetComponent<Transform>().position.y + yoffset,zoffset);
        
    }
}
