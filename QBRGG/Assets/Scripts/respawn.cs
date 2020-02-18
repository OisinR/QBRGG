using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{

    public bool dead;

    checkpoints checkpointsScript;

    // Start is called before the first frame update
    void Start()
    {
        checkpointsScript = GetComponent<checkpoints>();   
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.y < -200)
        {
            dead = true;
        }
        if(dead)
        {
            transform.position = checkpointsScript.checkpoint[checkpointsScript.index].transform.position;

        }
    }
}
