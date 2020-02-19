using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class countdown : MonoBehaviour
{
    public AudioSource speaker;
    public Text timeCount;
    
    void Start()
    {
        StartCoroutine(countdownTimer());
    }


    IEnumerator countdownTimer()
    {
        timeCount.text = "3";
        yield return new WaitForSeconds(1f);
        timeCount.text = "2";
        yield return new WaitForSeconds(1f);
        timeCount.text = "1";
        yield return new WaitForSeconds(1f);
        timeCount.text = "GO";
        stere.canGo = true;
        yield return new WaitForSeconds(1f);
        timeCount.text = "";
        speaker.Play();
    }
}
