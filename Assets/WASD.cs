using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class WASD : MonoBehaviour
{
    public float accel = if;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // FixedUpdate is called every physics update

   void FixedUpdate()
    {

        transform.Translate(Dir()*accel);


    }

   public Vector3 Dir()
    {
        float y = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");

        Vector3 myDir = new Vector3(x, y, 0);
        retun myDir;
    }
}
