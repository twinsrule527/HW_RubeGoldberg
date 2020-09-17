using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTrigger : MonoBehaviour
{
    public Transform cameraTransform;//Exposed in the Inspector
    //automatically happen when something with a 2d rigid body enters this trigger
    void OnTriggerEnter2D(Collider2D activator) {
        //Camera changes to focus on the activator object
        cameraTransform.position = activator.transform.position + new Vector3( 0f, 0f, -10f );
    }
    //When a 2Drigidbody exits the trigger
    void OnTriggerExit2D(Collider2D activator) {
            Debug.Log(activator.name + " left the scene");

    }


}
