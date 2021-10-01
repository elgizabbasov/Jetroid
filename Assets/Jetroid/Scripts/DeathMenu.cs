using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public Text timerText;
    public void Setup(string timeAlive){
        gameObject.SetActive(true);
        timerText.text = timeAlive;
    }

    public void RestartGame(){
        SceneManager.LoadScene("Level 1");
    }

    public void QuitToMenu(){
        SceneManager.LoadScene(0);
    }


}
