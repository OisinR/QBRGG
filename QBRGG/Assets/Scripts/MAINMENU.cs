using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MAINMENU : MonoBehaviour
{

    public void LoadLevel()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 0);
        StartCoroutine(LetTheBellRing());
    }

    IEnumerator LetTheBellRing()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("_Main");
    }

}