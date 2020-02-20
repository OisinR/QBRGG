using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public int num;

    void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, 30 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" || other.gameObject.tag == "Player2")
        {
            other.gameObject.GetComponent<pickup>().UI[other.gameObject.GetComponent<pickup>().index].SetActive(false);
            other.gameObject.GetComponent<pickup>().index = num;
            Destroy(gameObject);
        }
    }

}
