using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class center : MonoBehaviour
{
    public Vector3 cOfM;
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.centerOfMass = cOfM;
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position + transform.rotation * cOfM, 0.1f);
    }
}
