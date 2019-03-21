using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackPower : APower
{
    private bool canActive;
    private bool hangingSomeone;
    private Collision2D collide;

    private void Start()
    {
        canActive = false;
        hangingSomeone = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canActive = true;
            collide = collision;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canActive = false;
        }
    }

    public override void launchPower()
    {
        if (hangingSomeone)
        {
            hangingSomeone = false;
            collide.gameObject.GetComponent<BoxCollider2D>().enabled = true;
            collide.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x * 20, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (canActive)
        {
            collide.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
            collide.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            hangingSomeone = true;
            canActive = false;
        }
    }

    public override void stopPower()
    {
    }

    private void Update()
    {
        if (hangingSomeone)
        {
            collide.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
        }
    }
}
