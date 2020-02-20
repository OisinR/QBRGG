using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public GameObject target;
    public int index;
    public GameObject mud;
    public bool Player1;
    stere stereScript;
    Rigidbody rb;

    private void Start()
    {
        stereScript = GetComponent<stere>();
        rb = GetComponent<Rigidbody>();
    }


    IEnumerator Mud()
    {
        mud.SetActive(true);
        yield return new WaitForSeconds(2);
        mud.SetActive(false);
    }

    IEnumerator Speed()
    {
        stereScript.boosted = true;
        yield return new WaitForSeconds(4);
        stereScript.boosted = false;
    }

    IEnumerator Slow()
    {
        target.GetComponent<stere>().slowed = true;
        yield return new WaitForSeconds(3);
        target.GetComponent<stere>().slowed = false;
    }

    IEnumerator Reverse()
    {
        target.GetComponent<stere>().reverse = true;
        yield return new WaitForSeconds(5);
        target.GetComponent<stere>().reverse = false;
    }

    void Update()
    {
        if (Player1)
        {
            if (Input.GetButtonDown("A ButtonP1") && index != 0)
            {
                if (index == 1)
                {
                    StartCoroutine(Mud());
                    index = 0;
                }
                if (index == 2)
                {
                    StartCoroutine(Speed());
                    index = 0;
                }
                if (index == 3)
                {
                    StartCoroutine(Slow());
                    index = 0;
                }
                if (index == 4)
                {
                    StartCoroutine(Reverse());
                    index = 0;
                }
            }

        }
        else
        {
            if (Input.GetButtonDown("A ButtonP2") && index != 0)
            {
                if (index == 1)
                {
                    StartCoroutine(Mud());
                    index = 0;
                }
                if (index == 2)
                {
                    StartCoroutine(Speed());
                    index = 0;
                }
                if (index == 3)
                {
                    StartCoroutine(Slow());
                    index = 0;
                }
                if (index == 4)
                {
                    StartCoroutine(Reverse());
                    index = 0;
                }
            }
        }
    }
}
