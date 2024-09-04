using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class WASD : MonoBehaviour
{
    public float accel = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // FixedUpdate is called every physics update
    //void functions do not return any data
   void FixedUpdate()
    {

        //first let's call our Dir() function to find out what the current player inputs are
        Vector3 currentDir = Dir();
        //throw it into Trnaslate, multiply by our acceleration variable
        transform.Translate(currentDir*accel);


    }

    //get the inputs of the WASD / keyboard / joysticks\
    //this function gets the overall direction and returns it as a vector3
   public Vector3 Dir()
    {
        //Unitys's default axes provide a value between -1 to 1
        //in the case of vertical, thats's W = 1 and S = -1
        float y = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");

        //construct our vector out of the vertical/horizontal axis
        Vector3 myDir = new Vector3(x, y, 0);
        //then we return the value
        return myDir;
    }
}
