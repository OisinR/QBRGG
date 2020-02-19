using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointsScene : MonoBehaviour
{

    public bool doneP1,doneP2;


    void Start()
    {

    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !doneP1)
        {
            other.gameObject.GetComponent<checkpoints>().index++;
            doneP1 = true;
        }
            
    if (other.gameObject.tag == "Player2" && !doneP2)
        {
            other.gameObject.GetComponent<checkpoints>().index++;
            doneP2 = true;
        }
    }
}
