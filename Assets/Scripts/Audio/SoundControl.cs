using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SoundControl : MonoBehaviour
{
    public Slider slider;
    public GameObject audioObject;
    private AudioSource audioSource;
 
    void Awake()
    {
        // Link the value of the slider to the volume of audioSource
        audioSource = audioObject.GetComponent<AudioSource>();
        slider.onValueChanged.AddListener((value) => { audioSource.volume = value; });
        audioSource.volume = slider.value;
    }
}
