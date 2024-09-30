using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{


    public float speed;
    public GameObject Enemy;
    public GameObject targetPlayer;
   

    // Update is called once per frame
    void Update()
    {
        
    }

    void Follow()
    {
       

        GetComponent<EnemyFollow>().targetPlayer = GameObject.FindGameObjectWithTag("Player");

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            WASD temp = collision.gameObject.GetComponent<WASD>();
            temp.collectedScore -= 1;
        }
    }
}
