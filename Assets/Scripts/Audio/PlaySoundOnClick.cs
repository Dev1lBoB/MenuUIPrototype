using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class PlaySoundOnClick : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        // Save a reference to the sound into the prefab
        audioSource = GameObject.Find("ClickSound").GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        audioSource.Play();
    }
}
