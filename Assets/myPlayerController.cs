using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myPlayerController : MonoBehaviour
{

    public float speed;
    public float jumpforce;
    public float rotationSpeed;
    public Rigidbody rb;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //If key "W" pressed
        if (Input.GetKey(KeyCode.W))
        {
            
            rb.AddForce(transform.forward * speed);

        }
        //If key "S" pressed
        if (Input.GetKey(KeyCode.S))
        {
            
            rb.AddForce(transform.forward * -speed);

        }
        //If key "A" pressed
        if (Input.GetKey(KeyCode.A))
        {

            rb.MoveRotation(Quaternion.AngleAxis(transform.localEulerAngles.y - rotationSpeed, transform.up));

        }
        //If key "D" pressed
        if (Input.GetKey(KeyCode.D))
        {

            rb.MoveRotation(Quaternion.AngleAxis(transform.localEulerAngles.y + rotationSpeed, transform.up));

        }
        //if space pressed while touching ground
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            //jump
            rb.AddForce(Vector3.up * jumpforce);
        }
    }

    //Collision Detect
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "coinPickup")
        {
            //Destroy objects
            Destroy(col.gameObject);

        }

    }

    private void OnTriggerEnter(Collider collision)
    {
        isGrounded = true;
    }


    private void OnTriggerExit(Collider collision)
    {
        isGrounded = false;
    }
}
