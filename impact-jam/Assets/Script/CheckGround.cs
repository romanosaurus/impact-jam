using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool Grounded;


    void OnCollisionEnter2D(Collision2D collider)
    {
        Grounded = true;
    }

    void OnCollisionExit2D(Collision2D collider)
    {
        Grounded = false;
    }
}
