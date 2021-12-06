using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameComplete : MonoBehaviour
{
    [SerializeField] 
    private Text timer;

    void Start()
    {
        timer.text = TimerController.instance.EndTimer();
    }
}
