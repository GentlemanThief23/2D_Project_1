using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Did the player hit us?
        if (collision.CompareTag("Player"))
        {
            // Trigger the game over state on the player.
            collision.GetComponent<PlayerController>().GameOver();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
