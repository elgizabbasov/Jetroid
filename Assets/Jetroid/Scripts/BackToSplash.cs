using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToSplash : MonoBehaviour
{
    public void LoadScene() {
        SceneManager.LoadScene("SplashScene");
    }
}
