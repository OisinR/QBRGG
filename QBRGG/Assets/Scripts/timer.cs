﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text time, best;
    public static bool stop;

	void Start()
    {
        stop = false;
        time.text = "0.00";
        best.text = "" + System.Math.Round(PlayerPrefs.GetFloat("best"), 2);
    }




    private void Update()
    {
        if (!stere.canGo) { return; }
        if (!stop)
        {
            time.text = "" + System.Math.Round(Time.timeSinceLevelLoad, 2);

            if (Time.timeSinceLevelLoad > PlayerPrefs.GetFloat("best"))
            {
                PlayerPrefs.SetFloat("best", Time.timeSinceLevelLoad);
            }

            best.text = "" + System.Math.Round(PlayerPrefs.GetFloat("best"), 2);
        }
    }



}
