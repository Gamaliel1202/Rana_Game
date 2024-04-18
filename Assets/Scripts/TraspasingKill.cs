using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TraspasingKill : MonoBehaviour
{
    public float JumpForce = 10f;
    public Transform traspaserPlayer;
    public Transform traspaserPlatform;
    [SerializeField] private bool yallego = false;


    //[SerializeField] private UnityEvent _Muerte = new();


    public AudioSource ribbit;
    private void Awake()
    {
        yallego = false;
    }
    private void FixedUpdate()
    {
 




        if (traspaserPlayer.position.y - traspaserPlatform.position.y >= 0)
        {
            yallego = true;
        }


    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player pl = collision.GetComponent<Player>();
            Rigidbody rb = collision.GetComponent<Rigidbody>(); 



            if (yallego == true)
            {

                if (pl != null)
                {
                    Vector3 velocity = rb.velocity;
                    velocity.y = JumpForce;
                    rb.velocity = velocity;
                    pl.Death();
                    
                }
            }
        }
    }
}

