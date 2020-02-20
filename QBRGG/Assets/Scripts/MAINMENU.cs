using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MAINMENU : MonoBehaviour
{

    public void LoadLevel()
    {
        SceneManager.LoadScene("_Main");
        //StartCoroutine(LetTheBellRing());
    }

   /* IEnumerator LetTheBellRing()
    {
        yield return new WaitForSeconds(.1f);
        SceneManager.LoadScene("_Main");
    }*/

}