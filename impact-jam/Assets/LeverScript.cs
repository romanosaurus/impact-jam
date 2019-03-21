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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        firstState.SetActive(false);
        secondState.SetActive(true);
        bridge.SetActive(true);
    }
}
