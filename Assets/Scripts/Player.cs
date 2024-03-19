using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float MovementSpeed = 10f;

    Rigidbody2D rb;
    float Movement = 0f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
         Movement = Input.GetAxis("Horizontal") * MovementSpeed;
    }

     void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = Movement; 
        rb.velocity = velocity;
    }
}
