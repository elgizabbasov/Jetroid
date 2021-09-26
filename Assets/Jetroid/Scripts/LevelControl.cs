using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public int maxCrystals = 2;
    GameController gameController;

    void Start() {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player") && gameController.crystals != maxCrystals){
            print("Grab all the crystals first! " + gameController.crystals + " you need: " + maxCrystals);
        }
        else if (collision.CompareTag("Player") && gameController.crystals == maxCrystals){
            if(maxCrystals < 8) {
                maxCrystals++;
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


}
