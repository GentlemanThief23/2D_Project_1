using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    

    public GameObject Enemy;
    public GameObject targetPlayer;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Follow()
    {

        
        GetComponent<EnemyFollow>().targetPlayer = GameObject.FindGameObjectWithTag("Player");

    }
}
