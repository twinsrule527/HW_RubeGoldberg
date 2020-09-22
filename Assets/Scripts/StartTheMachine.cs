using System.Collections.Generic;
using UnityEngine;

public class StartTheMachine : MonoBehaviour
{   
    //This script has attached audio sources
    AudioSource audioData;

    //This is the power of the starting force used to propel the first ball
    private Vector2 starting_force = new Vector2(0.0f, 3000.0f);
    bool started = false;

    private Rigidbody2D rb2d;

    void Start() {
        //Setting up the Rigidbody
        rb2d = GetComponent<Rigidbody2D> ();
        //Sets up the AudioSource
        audioData = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        //If SPACE is pressed for the first time in the game, the force is applied
        if(Input.GetKey(KeyCode.Space)&& !started) {
            //The machine is started
            started = true;
            
            audioData.Play(0);
            //And the starting force is applied
            rb2d.AddForce(starting_force);
        }
    }
}
