using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    public GameObject player;       //Public variable to store a reference to the player game object
    private Vector3 offset;         //Private variable to store the offset distance between the player and camera
    public float FollowSpeed = 2f;
    // Use this for initialization
    private void Update()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x / 1000, Input.mousePosition.y / 1080, Input.mousePosition.z);
        Vector3 newPosition = player.transform.position;
        newPosition.z = -10;
        transform.position = Vector3.Slerp(transform.position, newPosition + mousePosition, FollowSpeed * Time.deltaTime);
    }
}
