using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class WASD : MonoBehaviour
{
    public float collectedScore = 0f;
    public float horAccel = .5f;
   public float vertAccel = .5f;

    public Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
          _rb = GetComponent<Rigidbody2D>();
        
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
        //multiply our horizontal and vertical move seperatley
        currentDir.x *= horAccel;
        currentDir.y *= vertAccel;
        //throw it into Translate, multiply by our acceleration variable
        transform.Translate(currentDir);


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

    //checkig for enemy or collectible or collisions
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("player collided with " + collision.gameObject.name);

        //when we collide with something collectible, destroy it and increment the player score
        if (collision.gameObject.tag == "Collectible")
        {
            Destroy(collision.gameObject);
            collectedScore++;
        }
    }
}
