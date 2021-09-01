using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static bool startTimer;
    public Text timerCounter;
    public static float timer = 0.0f;

    private void Start()
    {
        timer = 0.0f;
        startTimer = true;
    }

    void Update()
    {
        if (startTimer == true)
        {
            timer += Time.deltaTime;
            timerCounter.text = timer.ToString("0");
            PlayerPrefs.SetFloat("Timer", timer);
        }
    }
}