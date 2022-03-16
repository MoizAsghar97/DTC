using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool  timerIsRunning = false;
    public Text  timeText;

    public float tmpTime = 500;
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        timeRemaining = 300;
   
    }

    void Update()
    {
        if (timerIsRunning)
        {
     
            if (timeRemaining > 0)
            {
         
               
                timeRemaining = timeRemaining - Time.deltaTime ;
                System.Math.Round(timeRemaining,2);
             

                DisplayTime(timeRemaining);
               // Debug.Log(Time.deltaTime+" Time "+ timeRemaining);
            }
            else
            {
             //   Debug.Log("Time has run out!"+timeRemaining);
                timeRemaining = 0;
                timerIsRunning = false;
       
     
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        // Debug.Log("Time has run out!"+string.Format("{0:00}:{1:00}", minutes, seconds));
       
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
