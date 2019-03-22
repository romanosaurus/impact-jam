using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackPower : APower
{
    private bool canActive;
    private bool hangingSomeone;
    private GameObject holding;

    private void Start()
    {
        canActive = false;
        hangingSomeone = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !hangingSomeone)
        {
            canActive = true;
            holding = collision.gameObject;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !hangingSomeone)
        {
            canActive = false;
        }
    }

    public override void launchPower()
    {
        Debug.Log("launchPower");
        if (hangingSomeone)
        {
            hangingSomeone = false;
            holding.gameObject.GetComponent<BoxCollider2D>().enabled = true;
            holding.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x * 10, GetComponent<Rigidbody2D>().velocity.y);
            holding.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            holding = null;
        }
        if (canActive)
        {
            Debug.Log("HOLDING" + holding.gameObject.name);
            holding.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
            holding.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            hangingSomeone = true;
            canActive = false;
        }
    }

    public override void stopPower()
    {
    }

    private void Update()
    {
        //Debug.Log(holding.gameObject.name);
        if (hangingSomeone && holding != null)
        {
            holding.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
        }
    }
}
