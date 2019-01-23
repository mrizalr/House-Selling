using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GazeTime : MonoBehaviour {

    float timerSecond = 0f;
    float timerSpeed = 3f;
    float maxTimer = 5f;
    [SerializeField]bool timeStart = false;
    public bool timeFinish = false;

    public GameObject timerCanvas;
    public Image loadingBar;
    public Text secondText;

    private void Update()
    {
        GazeTimerCall();
    }

    void GazeTimerCall()
    {
        if (timeStart)
        {
            timerCanvas.SetActive(true);
            timerSecond += timerSpeed * Time.deltaTime;
            int timerDisplay = (int)timerSecond;
            secondText.text = timerDisplay.ToString() + "s";
            loadingBar.fillAmount = timerSecond*20/100;
        }

        if (timerSecond > maxTimer)
        {
            TimerStopTrigger();
            timeFinish = true;
        }

    }

    public void TimerStartTrigger()
    {
        timeStart = true;
    }

    public void TimerStopTrigger()
    {
        timerCanvas.SetActive(false);
        timeStart = false;
        timerSecond = 0f;
        int timerDisplay = (int)timerSecond;
        secondText.text = timerDisplay.ToString() + "s";
        timeFinish = false;
    }
}
