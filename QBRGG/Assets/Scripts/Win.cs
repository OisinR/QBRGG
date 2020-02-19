using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Win : MonoBehaviour
{
    public Text winText;
    bool won;
    public GameObject holder;
    public AudioSource speaker, speaker2;
    public AudioClip applause;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !won)
        {
            if(other.gameObject.GetComponent<checkpoints>().index == 8)
            {
                holder.SetActive(true);
                winText.text = "Player 1 Wins!";
                timer.stop = true;
                speaker.volume = speaker.volume / 2;
                speaker2.PlayOneShot(applause);
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
                speaker.volume = speaker.volume / 2;
                speaker2.PlayOneShot(applause);
                won = true;
            }
        }
    }
}
