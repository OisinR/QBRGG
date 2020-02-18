using System.Collections;
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
        time.text = "" + System.Math.Round(PlayerPrefs.GetFloat("best"));
    }




    private void Update()
    {
        if (!stop)
        {
            time.text = "" + System.Math.Round(Time.timeSinceLevelLoad, 2);

            if (Time.timeSinceLevelLoad > PlayerPrefs.GetFloat("best"))
            {
                PlayerPrefs.SetFloat("best", Time.timeSinceLevelLoad);
            }

            best.text = "" + System.Math.Round(Time.timeSinceLevelLoad, 2);
        }
    }



}
