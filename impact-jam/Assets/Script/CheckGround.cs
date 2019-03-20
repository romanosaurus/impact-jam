using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool Grounded;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            GetComponent<Properties>().speed -= 75;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            GetComponent<Properties>().speed += 75;

        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {

        Grounded = true;
    }

    void OnCollisionExit2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Water")
        {
            GetComponent<Properties>().speed += 50;
        }
        Grounded = false;
    }
}
