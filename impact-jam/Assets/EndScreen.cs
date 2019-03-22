using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    public Text time;
    public Text timeTextInEndScreen;
    private bool updated = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Canvas>().enabled == false)
        {
            timeTextInEndScreen.text = time.text;
            updated = true;
        }
    }
}
