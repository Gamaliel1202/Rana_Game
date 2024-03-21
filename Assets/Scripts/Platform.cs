using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{


    public float JumpForce = 10f;
    public Transform traspaserPlayer;
    public Transform traspaserPlatform;
    [SerializeField] private bool yallego=false;

    private void Awake()
    {
        yallego = false;
    }
    private void FixedUpdate()
    {
        if (traspaserPlayer.position.y - traspaserPlatform.position.y >= 0)
        {
            yallego = true;
          // Debug.Log(yallego);
        }
       
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag ("Player"))
        {
            Rigidbody rb = collision.GetComponent<Rigidbody>();



            if (yallego == true)
            {

                if (rb != null)
                {

                    Vector3 velocity = rb.velocity;
                    velocity.y = JumpForce;
                    rb.velocity = velocity;

                }
            }
        }
    }
}




