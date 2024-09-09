using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    //public time passed variable
    public float myTimer = 0f;
    //
    public float myFixedTimer = 0f;

    public GameObject myPlayer;
    public GameObject myCollectible;
    public TextMeshProUGUI myScore;
    WASD playerScript;
    float playerscore;

    public float spawnInterval = .5f;
    public float spawnTimer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        myPlayer = GameObject.FindGameObjectWithTag("Player");
        playerScript = myPlayer.GetComponent<WASD>();

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
            Instantiate(myCollectible);
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
