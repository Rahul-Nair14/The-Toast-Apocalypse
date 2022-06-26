using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MMLoader : MonoBehaviour
{
    public void LMainMenu()
    {


        SceneManager.LoadScene(0);
        Time.timeScale = 1;

    }
}
