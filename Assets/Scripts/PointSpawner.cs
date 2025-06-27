using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawner : MonoBehaviour
{
    public GameObject pointsPrefab;
    private Vector2 spawnPosition = new Vector2(10.5f, 0);
    private Vector2 spawnPosition1 = new Vector2(12.5f, 0);
    private Vector2 spawnPosition2 = new Vector2(14.5f, 0);
    private float startDelay = 2f;
    private float repeatRate = 2f;
    PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPointObstacles", startDelay, repeatRate);
        InvokeRepeating("SpawnNewPoints", startDelay, repeatRate);
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnPointObstacles()
    {
        if (playerController.isGameOver == false) 
        {
            //int obstacleIndex = Random.Range(0, pointsPrefab.Length);
            Instantiate(pointsPrefab, spawnPosition, pointsPrefab.transform.rotation);
        }

    }

    void SpawnNewPoints() 
    {
        if (ScoreScript.scoreValue >= 10 && playerController.isGameOver == false)
        {
            Instantiate(pointsPrefab, spawnPosition1, pointsPrefab.transform.rotation);
        }
        else if (ScoreScript.scoreValue >= 40 && playerController.isGameOver == false) 
        {
            Instantiate(pointsPrefab, spawnPosition2, pointsPrefab.transform.rotation);
        }
    }

}
