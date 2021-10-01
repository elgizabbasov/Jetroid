using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public int crystals = 0;
    [SerializeField] private Text crystalsText;
    
    // Start is called before the first frame update
    void Start()
    {
        TimerController.instance.BeginTimer();
    }

    // Update is called once per frame
    void Update()
    {
        crystalsText.text = "Crystals: " + crystals + "/" + LevelControl.instance.currCrystalLevel;
    }
}