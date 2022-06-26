using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplayScript : MonoBehaviour
{
    public static float FinalScore;
    public Text ScoreText;
    void Start()
    {
        FinalScore = PlayerPrefs.GetFloat("Score");
        ScoreText.text = "SCORE - "+FinalScore.ToString("F2");
    }

   
}
