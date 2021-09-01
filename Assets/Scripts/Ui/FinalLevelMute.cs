using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLevelMute : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (DetectionMeter.currentDetection >= DetectionMeter.maxDetection)
        {
            audioSource.mute = !audioSource.mute;
            enabled = false;
        }
    }
}
