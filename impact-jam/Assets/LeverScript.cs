using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    [SerializeField]
    private GameObject firstState;
    [SerializeField]
    private GameObject secondState;
    [SerializeField]
    private GameObject bridge;
    private bool onlyOne;
    // Start is called before the first frame update
    void Start()
    {
        onlyOne = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        firstState.SetActive(false);
        secondState.SetActive(true);
        if (onlyOne)
        {
            if (!bridge.activeSelf)
                bridge.SetActive(true);
            else
                bridge.SetActive(false);
            onlyOne = false;
        }
    }
}
