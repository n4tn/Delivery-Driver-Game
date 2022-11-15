using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driving : MonoBehaviour
{
    [SerializeField]
    float steeringSpeed = 1f;
    [SerializeField]
    float moveSpeed = 20f; // can be overwrriten in disc 
    [SerializeField]
    float slowSpeed = 15f;
    [SerializeField]
    float boostSpeed = 30f;

    void Update()
    {
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float steerAmount = Input.GetAxis("Horizontal") * steeringSpeed * Time.deltaTime; //string ref are bad
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }
}
