using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mutebg : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (GameHealth.currentHealth >= GameHealth.maxHealth)
        {
            audioSource.mute = !audioSource.mute;
            enabled = false;
        }

        if(DetectionMeter.currentDetection >= DetectionMeter.maxDetection)
        {
            audioSource.mute = !audioSource.mute;
            enabled = false;
        }
    }
}
