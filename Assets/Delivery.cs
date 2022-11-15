using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    //[SerializeField]
    //Color32 hasPackageColour = new Color32(1, 1, 1, 1);
    [SerializeField]
    float destroyDelay = 0.5f;
    bool hasPackage = false;

    //SpriteRenderer spriteRenderer;

    //public void Start()
    //{
    //spriteRenderer = GetComponent<SpriteRenderer>();
    //}
    public void OnCollisionEnter2D(Collision2D other) // collides with another object
    {
        Debug.Log("A collision has happened");
    }
    public void OnTriggerEnter2D(Collider2D other) // enters an area
    {
        if (other.tag == "Package" && !hasPackage)
        {
            hasPackage = true;
            Debug.Log("Package picked up!");
            Destroy(other.gameObject, destroyDelay);
        }
        else if (other.tag == "Customer" && hasPackage == true)
        {
            Debug.Log("Package delivered!");
            hasPackage = false;
        }

    }
}
