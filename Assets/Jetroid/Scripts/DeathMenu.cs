using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public Text timerText;
    public void Setup(){
        // TODO: Argument: float timer
        gameObject.SetActive(true);
        // timerText = timer.ToString() " s or m or h";
    }

    public void RestartGame(){
        SceneManager.LoadScene("Level 1");
        // TODO: RESTART TIMER
    }

    public void QuitToMenu(){
        SceneManager.LoadScene(0);
    }


}
