using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragnshoot : MonoBehaviour
{
    Camera cam;
    public Rigidbody rb;
    public bool canmove = true;


    void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        //taking input from mouse
        if (Input.GetMouseButtonDown(0) && canmove)
        {

            Vector3 endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            endPoint.z = 0;

            Vector3 startPoint = transform.position;
            startPoint.z = 0;

            Vector3 force = Vector3.zero;
            force = (endPoint - startPoint).normalized;
            rb.AddForce(force * 10f, ForceMode.VelocityChange);
            canmove = false;
        }

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ground")
        {
            canmove = true;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
    // private void OnCollisionExit(Collision other)
    // {
    //     if (other.gameObject.tag == "ground")
    //     {
    //         canmove = false;
    //     }
    // }

}
