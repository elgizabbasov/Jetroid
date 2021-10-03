using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public static LevelControl instance;

    public void Awake(){
        instance = this;
    }
    
    public int currCrystalLevel = 2;
    private static int maxCrystals = 8;
    GameController gameController;
    SpriteRenderer sprite;

    void Start() {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        sprite = GetComponent<SpriteRenderer>();
    }
    
    void Update() {
        if (gameController.crystals == currCrystalLevel){
            sprite.color = new Color(0, 255, 0, 1);
        }
    }


    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player") && gameController.crystals != currCrystalLevel){
            print("Grab all the crystals first! " + gameController.crystals + " you need: " + currCrystalLevel);
        }
        else if (collision.CompareTag("Player") && gameController.crystals == currCrystalLevel){
            SoundManager.PlaySound("completing");
            if(currCrystalLevel < maxCrystals) {
                currCrystalLevel++;
            }
            PlayerPrefs.SetFloat("time", TimerController.instance.elapsedTime); // Save time when level completed
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


}
