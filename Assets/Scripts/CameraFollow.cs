using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public float SmoothSpeed = .3f;

    private Vector3 currentVelocity;
  
    void LateUpdate()
    {
        if (target.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);


            //transform.position = Vector3.SmoothDamp(transform.position, newPos,ref currentVelocity, SmoothSpeed * Time.deltaTime);
            transform.position = newPos;

        }
    }
}
