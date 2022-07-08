using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{   
   [Header("movi speed")]
   [SerializeField] float speed;
   [SerializeField] float FixSpeed = 1f;
 
   public float mouseX;
   public float mouseY;
   public Rigidbody rb;
   public ForceMode force_mod;




   void Start()
   {
      rb = GetComponent<Rigidbody>();
   }

   void FixedUpdate()
    {   
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");


        if (Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeForce(Vector3.left * speed * FixSpeed, force_mod);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddRelativeForce(Vector3.left * -speed * FixSpeed, force_mod);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.forward * speed * FixSpeed, force_mod);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(Vector3.forward * -speed * FixSpeed, force_mod);
        }

    }    

}
