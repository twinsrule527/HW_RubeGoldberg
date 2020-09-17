using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    //This trigger triggers when something enters its space, at which point that object becomes the object the camera follows
    void OnTriggerEnter2D(Collider2D activator) {
      Global.CameraFollow = activator.gameObject;
      Destroy(this);
    }
}
