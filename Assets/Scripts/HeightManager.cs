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
    public TextMeshProUGUI Puntaje;
    [SerializeField] private float Height;


    public void Start()
    {
        Height = Mathf.FloorToInt(Heightter.position.y);
    }

    public void FixedUpdate()
    {
       
        Puntaje.text=("Altura: "+ (Mathf.FloorToInt(Heightter.position.y)-Height)) ;



       
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Plataforma") ){
        
            if (Height >= 100)
            {
                
              other.gameObject.GetComponent<Transform>.position.y = positioner.position.y;
            }
        }
    }

}
