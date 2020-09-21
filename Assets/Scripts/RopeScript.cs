using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeScript : MonoBehaviour
{
    //This script is used to create a rope which the object swings from
    //Needed vectors
    Vector2 end1 = new Vector2(0f,0f);
    Vector2 end2 = new Vector2(1f,10f);
    DistanceJoint2D dj2D;

    Color black = new Color(0f, 0f, 0f, 1f);
     // Start is called before the first frame update

    void Start()
    {
        //Creating the Line Renderer and all of its base attributes
        LineRenderer line = gameObject.AddComponent<LineRenderer>();
        
        line.material = new Material(Shader.Find("Sprites/Default"));

        line.startWidth = 0.05f;

        line.startColor = black;

        line.endColor = black;

        dj2D = GetComponent<DistanceJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        LineRenderer line = GetComponent<LineRenderer>();
       
        //end1 = this.dj2D.anchor;
        end1 = this.transform.position;
        end2 = this.dj2D.connectedAnchor;


        line.SetPosition(0, end1);
        line.SetPosition(1, end2);
    }
}
