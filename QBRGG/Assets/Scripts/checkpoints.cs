using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoints : MonoBehaviour
{
    public GameObject[] checkpoint;
    public int index;


    void Start()
    {
        index = 0;
    }



    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "checkpoint")
        {
            index++;
        }
    }
}
