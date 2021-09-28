using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// MAX_CRYSTALS = 8;

public class LevelControl : MonoBehaviour
{
    public static LevelControl instance;

    public void Awake(){
        instance = this;
    }
    
    public int currCrystalLevel = 2;
    private int maxCrystals = 8;
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
            if(currCrystalLevel < maxCrystals) {
                currCrystalLevel++;
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


}
