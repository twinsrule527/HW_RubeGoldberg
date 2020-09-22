using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_PlayMusic : MonoBehaviour
{
    //This script will start playing the room's music when the machine starts
    bool started = false;

     AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        //Sets up the AudioSource
        audioData = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)&& !started) {
            started = true;

            audioData.Play(10);
        }
    }
}
