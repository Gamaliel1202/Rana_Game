using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreMenu : MonoBehaviour
{
    public TMP_Text text;
    public static float HighScoreCount=0, score=0;
    public void Start()
    {
        //var score = PlayerPrefs.GetFloat("HighScore", 0);
       

        //var stringText = $"HighScore : {score:00000}";
        //if (text != null)
        //    text.text = stringText;
        if (PlayerPrefs.HasKey("HighScore"))
        HighScoreCount = PlayerPrefs.GetFloat("HighScore");
        
       
    }
    public void Awake()
    {
        score = 0;
        HighScoreCount = 0;
    }




    public void FixedUpdate()
    {

        
        if(score > HighScoreCount)
        {
            HighScoreCount = score;
            PlayerPrefs.SetFloat("HighScore", HighScoreCount);
        }
        //text.text = (""+ HighScoreCount);

        //  var hs =  PlayerPrefs.GetFloat("HighScore", 0);




    }
    public void ResetScore()
    {
        score = 0;
        HighScoreCount = 0;


    }


}

   

