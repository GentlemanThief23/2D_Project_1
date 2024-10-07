using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MoveToObject : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;

    public float speed;
   
   

    // Update is called once per frame
    void Update()
    {
        Enemy.transform.position = Vector3.MoveTowards(Enemy.transform.position, Player.transform.position, speed);
        Debug.DrawRay(Player.transform.position, Vector3.up, Color.green);
        
    }

    void Follow()
    {
       
        

 
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
