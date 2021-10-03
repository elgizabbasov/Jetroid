using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontKillMyVibe : MonoBehaviour
{
    private static DontKillMyVibe instance = null;

    void Awake(){
        if (instance != null){
            Destroy(gameObject);
        } else {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
