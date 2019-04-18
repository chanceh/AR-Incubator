using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public Slider slider;

    int hour;
    int minutes;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();

    }

    void Update()
    {
        hour = (int)(1+((slider.value / 15)+6)%12);
        minutes = (int)(slider.value % 60);
        Printable();
    }

    void Printable()
    {
        string StrHour = hour.ToString();
        string StrMinutes = minutes.ToString("00");
        text.text = StrHour + ":" + StrMinutes;
    }
}
