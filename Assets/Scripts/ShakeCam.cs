using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCam : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator CamAnim;

    public void ShakeCamera()
    {
        CamAnim.SetTrigger("shake");
    }
}
