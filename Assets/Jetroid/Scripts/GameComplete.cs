using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameComplete : MonoBehaviour
{
    [SerializeField] 
    private Text timer;
    [SerializeField] 
    private Text bestTime;
    private bool completed = false;
    private float currTime = 0F;
    private TimeSpan span;

    void Start()
    {
        timer.text = TimerController.instance.EndTimer();
        currTime = PlayerPrefs.GetFloat("time");
        completed = true;
        checkBestTime();
    }

    public void checkBestTime(){
        if(completed){
            if(currTime < PlayerPrefs.GetFloat("bestTime") || PlayerPrefs.GetFloat("bestTime") == 0F){
                PlayerPrefs.SetFloat("bestTime", currTime);
            }
            setBestTime();
        }
    }   
    
    public void setBestTime(){
        span = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("bestTime"));
        bestTime.text = "Your Best: " + span.ToString("mm':'ss'.'ff");
    }
}
