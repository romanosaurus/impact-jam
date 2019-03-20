using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool Grounded;
    private bool inWater = false;

    void OnCollisionEnter2D(Collision2D collider)
    {
        Grounded = true;
    }

    void OnCollisionExit2D(Collision2D collider)
    {
        if (!inWater)
            Grounded = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            GetComponent<Properties>().speed -= 50;
            Grounded = true;
            inWater = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            GetComponent<Properties>().speed += 50;
            Grounded = false;
            inWater = false;
        }
    }

}
