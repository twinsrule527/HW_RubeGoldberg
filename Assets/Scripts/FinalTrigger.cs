using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTrigger : MonoBehaviour
{
    //This trigger will turn on a boolean which ends the run with a finale
    void OnTriggerEnter2D(Collider2D activator) {
        Global.EndGame = true;
        Destroy(this);
    }    
    
}
