using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GetValue : MonoBehaviour
{
    [SerializeField] Text puntaje;

    public void LoadSceneAndKeepValue()
    {
        string dataToKeep = puntaje.text;
        //StaticData.valueToKeep = dataToKeep;
        SceneManager.LoadScene(1);

    }


}
