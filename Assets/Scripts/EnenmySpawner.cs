using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnenmySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    private Vector2 enemySpawnPosition = new Vector2(10, 0);
    private Vector2 enemySpawnPosition1 = new Vector2(12, 0);
    private float startDelay = 2f;
    private float repeatRate = 2f;
    PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, repeatRate);
        InvokeRepeating("SpawnMoreEnemy", startDelay, repeatRate);
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy() 
    {
        if (playerController.isGameOver == false) 
        {
            int obstacleIndex = Random.Range(0, enemyPrefab.Length);
            Instantiate(enemyPrefab[obstacleIndex], enemySpawnPosition, enemyPrefab[obstacleIndex].transform.rotation);
        }
    }

    void SpawnMoreEnemy() 
    {
        if (ScoreScript.scoreValue >= 40 && playerController.isGameOver == false) 
        {
            int obstacleIndex = Random.Range(0, enemyPrefab.Length);
            Instantiate(enemyPrefab[obstacleIndex], enemySpawnPosition1, enemyPrefab[obstacleIndex].transform.rotation);
        }
    }
}
