using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    //public time passed variable
    public float myTimer = 0f;
    //
    public float myFixedTimer = 0f;

    public GameObject MyEnemy;
    public float spawnInterval = .5f;
    public float spawnTimer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //add time passed between frames
        myTimer += Time.deltaTime;

        spawnTimer += Time.deltaTime;
        if(spawnTimer >= spawnInterval)
        {
            spawnTimer = 0f;
            Instantiate(MyEnemy);
            Debug.Log("enemy spawn");
        }
    }

    void FixedUpdate()
    {
        //add time passed between each physics frame
        myFixedTimer += Time.fixedDeltaTime; 
    }
}
