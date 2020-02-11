using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stere : MonoBehaviour
{
    public  Vector3 velocity = new Vector3(0.6f, 0, 0.1f);
    public Vector3 acceleration = Vector3.zero;
    public Vector3 force = Vector3.zero;

    public float mass = 1.0f;

    public float maxSpeed = 5;
    public float maxForce = 10;

    public float speed = 0;

    public bool seekEnabled = false;
    public Vector3 target;
    public Transform targetTransform;

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

        //f += Input.GetAxis("Vertical") * transform.forward * playerForce;

        Vector3 projectedRight = transform.right;
        projectedRight.y = 0;
        projectedRight.Normalize();

        f += Input.GetAxis("Horizontal") * projectedRight * 0.2f;


        return f;
    }

    public void OnDrawGizmos()
    {

        Gizmos.color = Color.green;
        Gizmos.DrawSphere(target, 0.1f);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + acceleration);

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, transform.position + velocity);

        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(targetTransform.position, slowingDistance);
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

    // Update is called once per frame
    void Update()
    {
        if (targetTransform != null)
        {
            target = targetTransform.position;
        }
        force = CalculateForce();
        acceleration = force / mass;
        velocity += acceleration * Time.deltaTime;

        //transform.position += velocity * Time.deltaTime;
        //speed = velocity.magnitude;
        if (speed > 0)
        {
            Vector3 tempUp = Vector3.Lerp(transform.up, Vector3.up + (acceleration * banking), Time.deltaTime * 1f);
            transform.LookAt(transform.position + velocity, tempUp);
            //transform.forward = velocity;
            velocity -= (damping * velocity * Time.deltaTime);


        }
    }
}