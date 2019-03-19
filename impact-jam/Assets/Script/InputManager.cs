using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public GameObject gm;
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
        if (Input.GetKey(KeyCode.D))
        {
            if (!Input.GetKey(KeyCode.LeftShift))
                rb.velocity = new Vector2(prop.speed * Time.deltaTime, rb.velocity.y);
            else
                rb.velocity = new Vector2((prop.speed + prop.speedSprint) * Time.deltaTime, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            if (!Input.GetKey(KeyCode.LeftShift))
                rb.velocity = new Vector2(-prop.speed * Time.deltaTime, rb.velocity.y);
            else
                rb.velocity = new Vector2(-((prop.speed + prop.speedSprint) * Time.deltaTime), rb.velocity.y);
        }
        // Handle press on Space key
        if (Input.GetKey(KeyCode.Space) && Grounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, prop.jumpForce * Time.deltaTime);
        }
    }
}
