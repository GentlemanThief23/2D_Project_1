using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hazardbehaviour : MonoBehaviour
{
    public GameObject Hazard
        ;

    public Transform LeftWall;
    public Transform RightWall;
    public Transform Ceiling;
    public Transform Ground;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1, 1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {

        int xpos = (int)Random.Range(LeftWall.position.x, RightWall.position.x);
        int ypos = (int)Random.Range(Ceiling.position.y, Ground.position.y);

        Instantiate(Hazard, new Vector3(xpos, ypos, 0), Quaternion.identity);

    }
}
