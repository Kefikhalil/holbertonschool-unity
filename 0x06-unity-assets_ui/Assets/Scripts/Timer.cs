using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timerText;

    private float countMilliSecond;

    private float countSeconds;

    private int countMinutes;

    private bool stop = false;

    void Start()
    {

    }
    public void Stop()
    {
        this.stop = true;
        this.timerText.color = Color.green;
        this.timerText.fontSize = 60;
    }
    private void Update()
    {
        if (!this.stop)
            this.timerText.text = string.Format(
                "{0}:{1:00.00}",
                Mathf.RoundToInt(Time.time / 60),
                Time.time % 60
            );

        //public void Win()
        {
        }

        // Update is called once per frame
        //void Update()
        {
            //UpdateTimerUI();
        }

        /*public void UpdateTimerUI()
        {
            countMilliSecond += Time.deltaTime * 100;
            if (countSeconds < 10)
                timerText.text = countMinutes + ":0" + (int)countSeconds + "." + (int)countMilliSecond;
            else
                timerText.text = countMinutes + ":" + (int)countSeconds + "." + (int)countMilliSecond;

            if (countMilliSecond >= 60)
            {
                countSeconds++;
                countMilliSecond = 0;
            }
            else if (countSeconds >= 60)
            {
                countMinutes++;
                countSeconds = 0;
            }
        }*/
    }
}
