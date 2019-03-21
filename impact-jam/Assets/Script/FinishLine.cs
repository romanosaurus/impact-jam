using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    public Canvas endScreen;
    private int playerIn = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            playerIn++;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            playerIn--;
    }

    private void Update()
    {
        if (playerIn == 4)
        {
            endScreen.enabled = true;
            endScreen.GetComponent<Animator>().enabled = true;
        }
    }
}
