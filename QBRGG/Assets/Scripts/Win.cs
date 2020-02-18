using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Win : MonoBehaviour
{
    public Text winText;
    bool won;
    public GameObject holder;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !won)
        {
            if(other.gameObject.GetComponent<checkpoints>().index == 8)
            {
                holder.SetActive(true);
                winText.text = "Player 1 Wins!";
                timer.stop = true;
                won = true;
            }

        }

        if (other.gameObject.tag == "Player2" && !won)
        {
            if (other.gameObject.GetComponent<checkpoints>().index == 8)
            {
                holder.SetActive(true);
                winText.text = "Player 2 Wins!";
                timer.stop = true;
                won = true;
            }
        }
    }
}
