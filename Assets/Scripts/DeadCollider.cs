using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeadCollider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Dead"))
        { Destroy(collision.gameObject); }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Plataformas"))
        { Destroy(other.gameObject); }
    }
}
