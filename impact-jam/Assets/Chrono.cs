using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chrono : MonoBehaviour
{
    public Text time;
    private float old;

    private void Start()
    {
        old = 0.0f;
    }
    // Update is called once per frame
    void Update()
    {
        old += Time.deltaTime;
        string test = string.Format("{0}:{1:00}", (int)old / 60, (int)old % 60);
        time.text = test;
    }
}
