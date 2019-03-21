using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DwarfPower : APower
{
    public ParticleSystem pt;
    public float speedImprove;
    bool active;
    float timeLeft;

    private void Start()
    {
        active = false;
        pt.Stop();
    }
    public override void launchPower()
    {
        if (active == false)
        {
            timeLeft = 5;
            pt.Play();
            GetComponent<Properties>().speed += speedImprove;
            active = true;
        }
    }

    public override void stopPower()
    {

    }

    private void Update()
    {
        if (timeLeft < 0)
        {
            GetComponent<Properties>().speed -= speedImprove;
            pt.Stop();
            active = false;
            timeLeft = 1;
        }
        else if (active)
        {
            timeLeft -= Time.deltaTime;
        }
    }
}
