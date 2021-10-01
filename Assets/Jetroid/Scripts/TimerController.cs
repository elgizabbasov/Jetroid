using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour
{
    public static TimerController instance;

    public Text timeCounter;
    
    private TimeSpan timePlaying;
    private bool timerGoing;

    public float elapsedTime;
    
    private void Awake(){
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        timeCounter.text = "Time: 00:00.00";
        timerGoing = false;
    }

    public void BeginTimer(){
        timerGoing = true;

        // if its the first level, elapsed time starts with elapsed time = 0; 
        // else elapsed time = the previous level's elapsed time
        
        if (SceneManager.GetActiveScene().buildIndex == 1)
            elapsedTime = 0f;
        else
            elapsedTime = PlayerPrefs.GetFloat("time");
        StartCoroutine(UpdateTimer());
    }

    public string EndTimer(){
        timerGoing = false;
        return timeCounter.text.ToString();
    }

    private IEnumerator UpdateTimer(){
        while(timerGoing){
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
            timeCounter.text = timePlayingStr;
            yield return null;
        }
    }

}
