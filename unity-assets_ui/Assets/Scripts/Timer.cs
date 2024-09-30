using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject winCanvas;
    public Text timerText;
    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;

        string minutes = ((int) t / 60).ToString();
        string seconds = ((int) t % 60).ToString("D2");
        string hundredths = ((int)(t * 100) % 100).ToString("D2");

        timerText.text = $"{minutes}:{seconds}.{hundredths}";
    }

    public void Win()
    {
        winCanvas.transform.Find("FinalTime").GetComponent<Text>().text = timerText.text;
        timerText.text = "";
    }
}
