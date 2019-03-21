using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBoyPower : APower
{
    public float jumpImprove;

    private Quaternion baseRotation;
    private bool powerActive;

    private void Start()
    {
        powerActive = false;
        baseRotation = transform.rotation;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && powerActive)
        {
            collision.gameObject.GetComponent<Properties>().jumpForce += jumpImprove;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && powerActive)
        {
            collision.gameObject.GetComponent<Properties>().jumpForce -= jumpImprove;
        }
    }

    public override void launchPower()
    {
        if (transform.rotation == baseRotation)
        {
            transform.Rotate(Vector3.forward * transform.localScale.x * 90);
            powerActive = true;
        }
    }

    public override void stopPower()
    {
        transform.rotation = baseRotation;
        powerActive = false;
    }
}
