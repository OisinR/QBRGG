using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float thrust = 30.0f;

    Rigidbody rb;
    int button;
    bool rt, lt;

   

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        button = 0;
    }




	private void Update()
    {
        {
            //Debug.Log(Input.GetAxis("Right Trigger"));
            /*

            if (Input.GetAxis("Right Trigger") == 1)
            {
                Debug.Log(123412313);
            }

            if (Input.GetAxis("Left Trigger") == 1 )
            {
                Debug.Log(435345345);
            }
            if (Input.GetButtonDown("Right Button"))
            {
                Debug.Log(666666666);
            }

            if (Input.GetButtonDown("Left Button"))
            {
                Debug.Log(0000000000000);
            }
            */
        }

        if(button == 0)
        {
            if (Input.GetButton("Right Button"))
            {
                //rb.AddForce(transform.forward * thrust);
                Debug.Log(1);
                if (Input.GetAxis("Right Trigger") == 1)
                {
                    rb.AddForce(transform.forward * thrust);
                    Debug.Log(2);
                    button++;
                }
            }
        }/*
        if (button == 1)
        {
            if (Input.GetAxis("Right Trigger") == 1)
            {
                rb.AddForce(transform.forward * thrust);
                Debug.Log(2);
                button++;
            }
        }*/
        if (button == 1)
        {
            if (Input.GetButton("Left Button"))
            {
                //rb.AddForce(transform.forward * thrust);
                Debug.Log(3);
                if (Input.GetAxis("Left Trigger") == 1)
                {
                    rb.AddForce(transform.forward * thrust);
                    Debug.Log(4);
                    button = 0;
                }
            }
        }
        /*
        if (button == 3)
        {
            if (Input.GetAxis("Left Trigger") == 1)
            {
                rb.AddForce(transform.forward * thrust);
                Debug.Log(4);
                button = 0;
            }
        }*/
    }



}
