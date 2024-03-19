using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;





[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float MovementSpeed = 10f;
    public float MovementSpeedV = 10f;
    bool IsGrounded = false;

    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer spriteRenderer;
    float Movement = 0f;
    float MovementV = 0f;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement = Input.GetAxis("Horizontal") * MovementSpeed;

        MovementV = Input.GetAxis("Vertical") * MovementSpeedV;

       // IsGrounded = false;
        //animator.GetBool("IsJumping");

    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = Movement;
        rb.velocity = velocity;
        theAnimations(velocity);

        //Vector2 velocityV = rb.velocity;
        //velocityV.y = MovementV;
        //rb.velocity = velocityV;




       // animator.SetFloat("xVelocity", Mathf.Abs(rb.velocity.x));
        animator.SetFloat("yVelocity", rb.velocity.y);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        IsGrounded = true;
        animator.SetBool("IsGrounded", true);
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        IsGrounded = false;
        animator.SetBool("IsGrounded", false);

    }

    public void theAnimations(Vector2 moveSpeed)
    {

        if (moveSpeed.x >= 0f)
        {
            Debug.Log("flipeado");

            spriteRenderer.flipX = true;
        }
        else if (moveSpeed.x <= 0f)
        { 
            spriteRenderer.flipX = false;
        }

     /*   if(moveSpeed.y > 0f )
        {
            if (!IsGrounded)
            {
                animator.Play("Impact");
            }
            else if (IsGrounded)
            {
                animator.Play("Jump");

            }
         
        }*/
        
    }
}
