using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Global {
    public static GameObject CameraFollow;
}
public class CameraMovement : MonoBehaviour
{
    //The Camera will follow whatever is the most recent object that is supposed to be followed
    
    //Several referential variables are used to make things easier
    Vector3 FollowPosition;
    float x;
    float y;
    float z;
    Vector3 Position;
    Vector3 Movement = new Vector3(0f,0f,0f);
    
    Vector3 Movement_Normal;
    // Update is called once per frame
    void Update()
    {   //Sets positions (in case reference is needed)
        Position = this.transform.position;
        x = Position.x;
        y=Position.y;
        z= Position.z;
        //Once the camera starts following an object
        if(Global.CameraFollow != null) {
            
            
            //It gets its position, and compares it to the camera's current position
            FollowPosition = Global.CameraFollow.transform.position;
            Movement = FollowPosition - Position;
        }
        if(Movement.magnitude < 0.5) {
            //if the camera is close enough to the object, it just moves in
            Movement_Normal = Movement;
            
        }
        else if(Movement.magnitude < 1) {
            //Otherwise it might normalize the vector
            Movement_Normal = Vector3.Normalize(Movement) / 2;
        }
        else {
            //Or, if the object is far enough away, it will bring itself halfway there
            Movement_Normal = Movement / 4;

        }
        //Then, finally, the camera moves
        this.transform.position += Movement_Normal;
        //Finally, we reset the z value, so that the camera will not be in the way of any objects
        this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y,-50.0f);

    }
}
