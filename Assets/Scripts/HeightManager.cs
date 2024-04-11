using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class HeightManager : MonoBehaviour
{
    public Transform Heightter;
    public Transform positioner;
   // public Transform Plat;

    public TextMeshProUGUI Puntaje;
    [SerializeField] private float Height;

    // [Header] ("PlatformType")

    [SerializeField] private List<Mesh> plataformas = new List<Mesh>();

    private Mesh actualObjeto;

    public GameObject base3;

    public static float Altura;
    

    public void Start()
    {
        Height = Mathf.FloorToInt(Heightter.position.y);

        actualObjeto = plataformas[0];
    }

    public void FixedUpdate()
    {

        var score = (Mathf.FloorToInt(Heightter.position.y) - Height);

        Puntaje.text = ("Altura: " + score);

        Altura = Height * 0.1f;

        PlayerPrefs.SetFloat("HighScore", score);




    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Plataformas"))
        {
            Debug.Log("posicionado");

            if (Altura <= 100)
            {
                Vector3 platformPosition = other.transform.position;
                other.gameObject.transform.position = new Vector3(transform.position.x, positioner.position.y, transform.position.z);

                //Instantiate(base3, transform.position, Quaternion.identity);

                ///Pendiente
                //other.GameObject<MeshRenderer>(Mesh) = actualObjeto = plataformas[0];


            }
        }
    }

 
}
