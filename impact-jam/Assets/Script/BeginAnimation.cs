using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeginAnimation : MonoBehaviour
{
    public string textLevel;
    public Text canvasText;
    void Start()
    {
        canvasText.text = textLevel;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
