using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    //Destroys this corresponding block at the end of the game
    // Update is called once per frame
    void Update()
    {
        if(Global.EndGame == true ) {
            
            Destroy(this);

        }
    }
}
