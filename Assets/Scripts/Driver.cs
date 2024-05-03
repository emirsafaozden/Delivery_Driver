using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{
   [SerializeField] float stearSpeed = 0.1f;
   [SerializeField] float moveSpeed = 10f;
   [SerializeField] float boostSpeed = 30f;
   [SerializeField] float slowSpeed = 15f;


    

    void Update()
    {

    float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
    float steerAmount = Input.GetAxis("Horizontal") * stearSpeed * Time.deltaTime;
    transform.Rotate(0, 0, -steerAmount);
    transform.Translate(0, moveAmount, 0);

    }

    void OnCollisionEnter2D(Collision2D other)
    {
       moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }

     
}
