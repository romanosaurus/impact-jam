using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool Grounded;
    private bool inWater = false;
    public static int jumpMax;
    private float DisstanceToTheGround;

    private void Start()
    {
        Grounded = true;
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Platform" || collider.gameObject.tag == "Player")
        {
            Grounded = true;
        }
    }

    /*private void OnCollisionStay(Collision collision)
    {
        Grounded = false;
    }*/

    void OnCollisionExit2D(Collision2D collider)
    {
        if (!inWater)
        {
            Grounded = false;
        }
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

    private void Update()
    {
        Debug.Log(Grounded);
    }
}
