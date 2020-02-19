using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    Rigidbody rb;
    public bool dead;

    checkpoints checkpointsScript;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        checkpointsScript = GetComponent<checkpoints>();   
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.y < -50)
        {
            dead = true;
        }
        if(dead)
        {
            transform.position = new Vector3(checkpointsScript.checkpoint[checkpointsScript.index -1].transform.position.x, checkpointsScript.checkpoint[checkpointsScript.index - 1].transform.position.y +3, checkpointsScript.checkpoint[checkpointsScript.index - 1].transform.position.z);
            transform.rotation = Quaternion.identity;//checkpointsScript.checkpoint[checkpointsScript.index - 1].transform.localRotation;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            dead = false;
        }
    }
}
