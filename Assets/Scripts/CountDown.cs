using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDown : MonoBehaviour
{
    public float totalTime;
    public TextMeshProUGUI text;

    public static float timer;

    private int minutes;
    private int seconds;

    public void Start()
    {
        timer = totalTime;
    }

    public void Update()
    {
        totalTime -= Time.deltaTime;
        minutes = (int)(totalTime / 60);
        seconds = (int)(totalTime % 60);
        if (minutes == 0 && seconds == 0)
        {
            timer = 0;
        }

        text.text = minutes.ToString("00") + ":" + seconds.ToString("00");

        PlayerPrefs.SetInt("finalTime", (int)timer);
    }

   

}
