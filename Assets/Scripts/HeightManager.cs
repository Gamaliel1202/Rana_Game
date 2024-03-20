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

    [SerializeField] private List<Mesh> meshes = new List<Mesh>();


    public void Start()
    {
        Height = Mathf.FloorToInt(Heightter.position.y);
    }

    public void FixedUpdate()
    {

        Puntaje.text = ("Altura: " + (Mathf.FloorToInt(Heightter.position.y) - Height));



    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Plataformas"))
        {
            Debug.Log("posicionado");

            if (Height <= 100)
            {
                Vector3 platformPosition = other.transform.position;
                other.gameObject.transform.position =  new Vector3(transform.position.x, positioner.position.y, transform.position.z);

            }
        }
    }

    //private void Positionator()
    //{
        //Debug.Log("posicionado");


    //    Vector3 platformPosition = transform.position;
    //    transform.position = new Vector3(transform.position.x, positioner.position.y, transform.position.z);

    //}
}
