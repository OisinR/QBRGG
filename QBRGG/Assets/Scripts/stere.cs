using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stere : MonoBehaviour
{
    public  Vector3 velocity = new Vector3(0.6f, 0, 0.1f);
    public Vector3 acceleration = Vector3.zero;
    public Vector3 force = Vector3.zero;
    public Rigidbody rb;

    public bool player1 = true;
    public float mass = 1.0f;

    public float maxSpeed = 5;
    public float maxForce = 10;

    public float speed = 0;

    public bool seekEnabled = false;


    public bool arriveEnabled = false;
    public float slowingDistance = 10;

    [Range(0.0f, 10.0f)]
    public float banking = 0.1f;

    public bool playerSteeringEnabled = false;
    public float playerForce = 10;

    public float damping = 0.1f;


    public Vector3 PlayerSteering()
    {
        Vector3 f = Vector3.zero;
        if(frame)
        {
            f += transform.forward * playerForce * 80;
        }


        Vector3 projectedRight = transform.right;
        projectedRight.y = 0;
        projectedRight.Normalize();
        if (player1)
        {
            f += Input.GetAxis("HorizontalP1") * projectedRight * 0.2f;
            //Debug.Log(234234);
        }
        else
        {
            f += Input.GetAxis("HorizontalP2") * projectedRight * 0.2f;
        }

        return f;
    }

    public float thrust = 30.0f;


    int button;
    bool rt, lt;
    bool frame, go;
    Vector3 movement;



    public void OnDrawGizmos()
    {


        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + acceleration);

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, transform.position + velocity);


    }


    public Vector3 CalculateForce()
    {
        Vector3 force = Vector3.zero;

        if (playerSteeringEnabled)
        {
            force += PlayerSteering();
        }
        return force;
    }

    void Movement()
    {
        if (player1)
        {
            if (button == 0)
            {
                if (Input.GetButton("Right ButtonP1"))
                {
                    if (Input.GetButton("Left ButtonP1"))
                    {
                        return;
                    }
                    //Debug.Log(1);
                    if (Input.GetAxis("Right TriggerP1") == 1)
                    {

                        frame = true;
                        //Debug.Log(2);
                        button++;
                    }
                }
            }
            if (button == 1)
            {
                if (Input.GetButton("Left ButtonP1"))
                {
                    if (Input.GetButton("Right ButtonP1"))
                    {
                        return;
                    }
                    //Debug.Log(3);
                    if (Input.GetAxis("Left TriggerP1") == 1)
                    {
                        frame = true;
                        //Debug.Log(4);
                        button = 0;
                    }
                }
            }
        }
        else
        {

            if (button == 0)
            {
                if (Input.GetButton("Right ButtonP2"))
                {
                    if (Input.GetButton("Left ButtonP2"))
                    {
                        return;
                    }
                    //Debug.Log(1);
                    if (Input.GetAxis("Right TriggerP2") == 1)
                    {

                        frame = true;
                        //Debug.Log(2);
                        button++;
                    }
                }
            }
            if (button == 1)
            {
                if (Input.GetButton("Left ButtonP2"))
                {
                    if (Input.GetButton("Right ButtonP2"))
                    {
                        return;
                    }
                    //Debug.Log(3);
                    if (Input.GetAxis("Left TriggerP2") == 1)
                    {
                        frame = true;
                        //Debug.Log(4);
                        button = 0;
                    }
                }
            }
        }
    }


    void Update()
    {
        frame = false;
        Movement();
        force = CalculateForce();
        acceleration = force / mass;
        velocity += acceleration * Time.deltaTime;

        transform.position += velocity * Time.deltaTime;
        speed = velocity.magnitude;
        if (speed > 0)
        {
            Vector3 tempUp = Vector3.Lerp(transform.up, Vector3.up + (acceleration * banking /2), Time.deltaTime * 1f);
            transform.LookAt(transform.position + velocity, tempUp);
            //transform.forward = velocity;
            velocity -= (damping * velocity * Time.deltaTime);

            
        }
        if (transform.rotation.z > 10)
        {
            rb.AddTorque(Vector3.forward * transform.rotation.z/1.5f);
        }
        if (transform.rotation.z < -10)
        {
            rb.AddTorque(Vector3.forward * -transform.rotation.z/1.5f);
        }
    }
}