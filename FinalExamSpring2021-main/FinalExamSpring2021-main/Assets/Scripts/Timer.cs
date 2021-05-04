using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    public float TimeLeft = SliderValueToText.sliderValueFloat * 1.0f;


    public void Start()
    {
        TimeLeft = SliderValueToText.sliderValueFloat;
    }
    private void Update()
    {
        TimeLeft -= Time.deltaTime;
        TimerText.text = TimeLeft.ToString();
        if (TimeLeft <= 0.0f)
        {
            TimerDone();
        }
    }

    void TimerDone()
    {
        TimerText.text = TimeLeft.ToString();
        TimeLeft = 0;
    }
}
