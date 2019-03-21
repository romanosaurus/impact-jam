using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Playsong : MonoBehaviour
{

    public AudioClip MusicClip;

    public AudioSource MusicSource;

    private void Start()
    {
        MusicSource.clip = MusicClip;
    }

    public void Test()
    {
        MusicSource.Play();
    }
}
