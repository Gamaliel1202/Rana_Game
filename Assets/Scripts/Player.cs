using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;





//[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{


    [SerializeField] private GameObject  GameOver;
    public float MovementSpeed = 10f;
    //public float MovementSpeedV = 10f;
    bool IsGrounded = false;

    Rigidbody rb;
    Animator animator;
    SpriteRenderer spriteRenderer;
    float Movement = 0f;
    //float MovementV = 0f;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement = Input.GetAxis("Horizontal") * MovementSpeed;

        //MovementV = Input.GetAxis("Vertical") * MovementSpeedV;

        IsGrounded = false;
        // animator.GetBool("IsJumping");

    }

    void FixedUpdate()
    {
        Vector3 velocity = rb.velocity;
        velocity.x = Movement;
        rb.velocity = velocity;
        theAnimations(velocity);

        //Vector2 velocityV = rb.velocity;
        //velocityV.y = MovementV;
        //rb.velocity = velocityV;




        // animator.SetFloat("xVelocity", Mathf.Abs(rb.velocity.x));
        animator.SetFloat("yVelocity", rb.velocity.y);
    }

    public void OnTriggerEnter(Collider collision)
    {
        // IsGrounded = true;

        if (collision.gameObject.CompareTag(("Enemy")))
        {

            Debug.Log("TOCOENEMIGO");
            animator.SetBool("Death", true);
            gameObject.layer.ToString("Cosas que no tocan nada");

            GameOver.SetActive(true);

        }
        else if(collision.gameObject.CompareTag("Plataformas"));
            {
        animator.SetBool("IsGrounded", true);
        Debug.Log("TouchGround");
            //reproducir audio en salto
            GameObject.Find("Ribbit").GetComponent<AudioSource>();
            

        } 
       


    }
    public void OnTriggerExit(Collider collision)
    {


        //IsGrounded = false;
        animator.SetBool("IsGrounded", false);

    }
    
    public void OnTriggerEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(("Enemy")))
        {

            Debug.Log("TOCOENEMIGO");
            animator.SetBool("Death", true);

        }
        }



    public void theAnimations(Vector3 moveSpeed)
    {

        if (moveSpeed.x > 0f)
        {

            spriteRenderer.flipX = true;
        }
        else if (moveSpeed.x < 0f)
        {
            spriteRenderer.flipX = false;
        }
        else if (moveSpeed.x == 0f)
        {
            spriteRenderer.flipY = spriteRenderer.flipY;
        }

     
        
    }
}
