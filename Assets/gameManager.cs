using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class gameManager : MonoBehaviour
{
    //public time passed variable
    public float myTimer = 0f;
    public TextMeshProUGUI gameOverText;
    //
    public float myFixedTimer = 0f;
    public Transform LeftWall;
    public Transform RightWall;
    public Transform Ceiling;
    public Transform Ground;
   
    public GameObject myPlayer;
    public GameObject myEnemy;
    public TextMeshProUGUI myScore;
    WASD playerScript;
    float playerscore;

    public float spawnInterval = 5f;
    public float spawnTimer = 5f;
    // Start is called before the first frame update
    void Start()
    {
        myPlayer = GameObject.FindGameObjectWithTag("Player");
        playerScript = myPlayer.GetComponent<WASD>();
        gameOverText.gameObject.SetActive(true);
       
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
           
            int xpos = (int)Random.Range(LeftWall.position.x, RightWall.position.x);
            int ypos = (int)Random.Range(Ceiling.position.y, Ground.position.y);

            GameObject temp = Instantiate(myEnemy, new Vector3(xpos, ypos, 0), Quaternion.identity);
            temp.GetComponent<MoveToObject>().Player = myPlayer;

            Debug.Log("enemy spawn");

        }
        playerscore = playerScript.collectedScore;
        myScore.text = playerscore.ToString();

        
       
    }
   
    

    
    void FixedUpdate()
    {
        //add time passed between each physics frame
        myFixedTimer += Time.fixedDeltaTime; 
    }
}
