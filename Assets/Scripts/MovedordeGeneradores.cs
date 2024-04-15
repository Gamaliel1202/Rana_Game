using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovedordeGeneradores : MonoBehaviour
{

    [Header("InfodeTransporte")]

    [SerializeField] private Transform alturaqueactiva;
    [SerializeField] private Transform player;

    [SerializeField] private Transform alturaalaquesepasa;

    void FixedUpdate()
    {

        if (player.position.y >= alturaqueactiva.position.y)
        {
            float esta = alturaalaquesepasa.position.y;
            transform.position = new Vector3(transform.position.x, esta, transform.position.z);
        }
}
}
