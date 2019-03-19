using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacter : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    public CameraFollowing cam;
    public InputManager input;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && input.gm == player1)
        {
            input.gm = player2;
            cam.player = player2;
        }
        else if (Input.GetKeyDown(KeyCode.E) && input.gm == player2)
        {
            input.gm = player3;
            cam.player = player3;
        }
        else if (Input.GetKeyDown(KeyCode.E) && input.gm == player3)
        {
            input.gm = player4;
            cam.player = player4;
        }
        else if (Input.GetKeyDown(KeyCode.E) && input.gm == player4)
        {
            input.gm = player1;
            cam.player = player1;
        }
    }
}
