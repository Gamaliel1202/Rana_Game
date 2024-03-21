using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float MovementSpeed = 10f;

    bool IsGrounded = false;

    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer spriteRenderer;
    float Movement = 0f;

    void Update()
    {
        Movement = Input.GetAxis("Horizontal") * MovementSpeed;
        Vector3 velocity = rb.velocity;
        rb.velocity = velocity;
        theAnimations(velocity);

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


    }
}
