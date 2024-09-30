using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hazardbehaviour : MonoBehaviour
{
    public GameObject Hazard;

    public Transform LeftWall;
    public Transform RightWall;
    public Transform Ceiling;
    public Transform Ground;

    void OnCollisionEnter(Collision collision)
    {
        // 2
        if (collision.gameObject.name == "Player")
        {
            // 3
            Destroy(this.transform.gameObject);
            // 4
        }
    }

        // Start is called before the first frame update
        void Start()
        {
            InvokeRepeating("Spawn", 1, .7f);

        }

        // Update is called once per frame
        void Update()
        {

        }

        void Spawn()
        {

            int xpos = (int)Random.Range(LeftWall.position.x, RightWall.position.x);
            int ypos = (int)Random.Range(Ceiling.position.y, Ground.position.y);

            GameObject temp = Instantiate(Hazard, new Vector3(xpos, ypos, 0), Quaternion.identity);
            temp.GetComponent<EnemyFollow>().targetPlayer = GameObject.FindGameObjectWithTag("Player");
        }

  
}
