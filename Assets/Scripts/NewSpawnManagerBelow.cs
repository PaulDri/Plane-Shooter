using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpawnManagerBelow : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private Vector2 spawnPosition = new Vector2(12, -6);
    private Vector2 spawnPosition1 = new Vector2(14, -6);
    private float startDelay = 2f;
    private float repeatRate = 2f;
    PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacles", startDelay, repeatRate);
        InvokeRepeating("SpawnMoreObstacles", startDelay, repeatRate);
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstacles()
    {
        if (ScoreScript.scoreValue >= 10 && playerController.isGameOver == false) 
        {
            int obstacleIndex = Random.Range(0, obstaclePrefab.Length);
            Instantiate(obstaclePrefab[obstacleIndex], spawnPosition, obstaclePrefab[obstacleIndex].transform.rotation);
        }

    }

    void SpawnMoreObstacles()
    {
        if (ScoreScript.scoreValue >= 30 && playerController.isGameOver == false)
        {
            int obstacleIndex = Random.Range(0, obstaclePrefab.Length);
            Instantiate(obstaclePrefab[obstacleIndex], spawnPosition1, obstaclePrefab[obstacleIndex].transform.rotation);
        }
    }
}
