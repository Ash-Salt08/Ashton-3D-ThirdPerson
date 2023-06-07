using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myPlayerController : MonoBehaviour
{

    public float speed;
    public float jumpforce;
    public float rotationSpeed;
    public Rigidbody rb;

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
            
            rb.AddForce(Vector3.forward * speed);

        }
        //If key "S" pressed
        if (Input.GetKey(KeyCode.S))
        {
            
            rb.AddForce(Vector3.back * speed);

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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //jump
            rb.AddForce(Vector3.up * jumpforce);
        }
    }
}
