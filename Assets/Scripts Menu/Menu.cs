using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    //Texto
    public TMP_Text text;
    public void Start()
    {
        var score = PlayerPrefs.GetFloat("HighScore", 0);
        var stringText = $"HighScore : {score:0}";
        if(text != null )
            text.text = stringText;
    }

    public void LoadLevel(int name)
    {
        SceneManager.LoadScene(name);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

