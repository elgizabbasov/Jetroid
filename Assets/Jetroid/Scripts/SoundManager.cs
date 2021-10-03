using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour
{

    public static AudioClip deathSound, flySound, completingSound, collectingSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        deathSound = Resources.Load<AudioClip>("dying");
        completingSound = Resources.Load<AudioClip>("completing");
        collectingSound = Resources.Load<AudioClip>("collecting");
        // flySound = Resources.Load<AudioClip>("flySound");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip){
        switch (clip){
        case "playerDying":
            audioSrc.PlayOneShot(deathSound);
            break;
        case "completing": 
            audioSrc.PlayOneShot(completingSound);
            break;
        case "collecting":
            audioSrc.PlayOneShot(collectingSound);
            break; 
        }
    }

}
