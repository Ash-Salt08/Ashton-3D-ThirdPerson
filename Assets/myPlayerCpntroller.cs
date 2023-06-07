using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myPlayerCpntroller : MonoBehaviour
{

    public float speed;
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

            rb.AddForce(Vector3.left * speed);

        }
        //If key "D" pressed
        if (Input.GetKey(KeyCode.D))
        {

            rb.AddForce(Vector3.right * speed);

        }
    }
}
