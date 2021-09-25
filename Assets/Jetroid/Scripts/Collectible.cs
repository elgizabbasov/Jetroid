using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    GameController gameController;

    void Start() {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    void OnTriggerEnter2D(Collider2D target){
        if (target.gameObject.CompareTag("Player")){
            Destroy(gameObject);
            gameController.crystals++;
        }
    }
}
