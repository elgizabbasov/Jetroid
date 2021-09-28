﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public DeathMenu deathMenu;
    public Debris debris;
    public int totalDebris = 10;
    [SerializeField] private AudioSource dyingSound; // TODO: NOT WORKING 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D target) { 
        if (target.gameObject.tag == "Deadly"){
            OnExplode();
        }
    }

    void OnCollisionEnter2D(Collision2D target) { 
        if (target.gameObject.tag == "Deadly"){
            OnExplode();
        }
    }

    void OnExplode(){
        var t = transform;

        for (int i = 0; i < totalDebris; i++) {
            t.TransformPoint(0, -100, 0);
            var clone = Instantiate(debris, t.position, Quaternion.identity) as Debris;
            var body2D = clone.GetComponent<Rigidbody2D>();
            body2D.AddForce(Vector3.right * Random.Range(-1000, 1000));
            body2D.AddForce(Vector3.up * Random.Range(-500, 2000));
        }
        dyingSound.Play(); // TODO: doesnt play!!
        Destroy(gameObject); 
        GameOver();  // TODO: Pass in the timer value
    }

    void GameOver(){
        deathMenu.Setup(); // TODO: Pass in the timer value
    }
}
