using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public GameObject gm;
    public Canvas canvas;
    public Animator animator;
    private Rigidbody2D rb;
    private Properties prop;

    private void Start()
    { }

    void Update()
    {
        rb = gm.GetComponent<Rigidbody2D>();
        prop = gm.GetComponent<Properties>();
        bool Grounded = CheckGround.Grounded;
        // Handle press on D key
        animator.SetFloat("Speed", (rb.velocity.x < 0) ? -rb.velocity.x : rb.velocity.x);

        if (Input.GetKey(KeyCode.D))
        {
            gm.GetComponent<APower>().stopPower();
            gm.transform.localScale = new Vector2(1, gm.transform.localScale.y);
            if (!Input.GetKey(KeyCode.LeftShift))
                rb.velocity = new Vector2(prop.speed * Time.deltaTime, rb.velocity.y);
            else
                rb.velocity = new Vector2((prop.speed + prop.speedSprint) * Time.deltaTime, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            gm.GetComponent<APower>().stopPower();
            gm.transform.localScale = new Vector2(-1, gm.transform.localScale.y);
            if (!Input.GetKey(KeyCode.LeftShift))
                rb.velocity = new Vector2(-prop.speed * Time.deltaTime, rb.velocity.y);
            else
                rb.velocity = new Vector2(-((prop.speed + prop.speedSprint) * Time.deltaTime), rb.velocity.y);
        }
        // Handle press on Space key
        if (Input.GetKey(KeyCode.Space) && Grounded)
        {
            gm.GetComponent<APower>().stopPower();
            rb.velocity = new Vector2(rb.velocity.x, prop.jumpForce * Time.deltaTime);
            Grounded = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvas.enabled)
                canvas.enabled = false;
            else
                canvas.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            gm.GetComponent<APower>().launchPower();
        }
    }
}
