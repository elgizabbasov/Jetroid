using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    public int crystals = 0;

    [SerializeField] private Text crystalsText;

    void OnTriggerEnter2D(Collider2D target){
        if (target.gameObject.CompareTag("Crystal")){
            Destroy(target.gameObject);
            crystals++;
            crystalsText.text = "Crystals: " + crystals;
        }
    }
}
